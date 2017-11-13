---
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 (on-premises)
  - Dynamics CRM 2016
  - Dynamics CRM Online
---

You interact with the Web API by composing and sending       HTTPrequests. You need to know how to set the appropriate       HTTPheaders and handle any errors included in the response.  
  
## In this topic  
 [Web API URL and versions](#bkmk_url_and_versions)  
  
 [HTTP methods](../Topic/Compose%20HTTP%20requests%20and%20handle%20errors.md#bkmk_methods)  
  
 [HTTP headers](../Topic/Compose%20HTTP%20requests%20and%20handle%20errors.md#bkmk_headers)  
  
 [Identify status codes](../Topic/Compose%20HTTP%20requests%20and%20handle%20errors.md#bkmk_statusCodes)  
  
 [Parse errors from the response](../Topic/Compose%20HTTP%20requests%20and%20handle%20errors.md#bkmk_parseErrors)  
  
<a name="bkmk_url_and_versions"></a>   
## Web API URL and versions  
 To access the Web API you must compose a URL using the components in the following table.  
  
|Item|Description|  
|----------|-----------------|  
|Protocol|The appropriate protocol, either                 `https://` or                 `http://`.|  
|Base URL|This is the URL you normally use to open the web application.<br /><br /> -   For                     Microsoft Dynamics 365 (online): use                     `<tenant name>.crm.dynamics.com`.<br />-   For                     Internet-facing deployment (IFD): use the appropriate URL for your instance. This will be:                     `<organization name>.<domain name>`.<br />-   For                     Dynamics 365 (on-premises): use                     `<server name>/<organization name>`|  
|Web API path|The path to the web API is                 `/api/data/`.|  
|Version|The version is expressed this way:                 `v[Major_version].[Minor_version][PatchVersion]/`. Valid versions for this release are:<br /><br /> -   `v8.0/` For Microsoft Dynamics CRM Online 2016 Update 0.1 and Microsoft Dynamics CRM 2016 Update 0.1<br />-   `v8.1/` For                     Microsoft Dynamics CRM 2016 Update 0.1 and                     Microsoft Dynamics CRM 2016 Update 0.1<br />-   `v8.2/` For                     December 2016 update for Dynamics 365 (online and on-premises)<br /><br /> The specific value you use is not important with this release as long as you have applied the corresponding updates or service packs. More information: [Version compatibility](#bkmk_version_compatibillity)|  
|Resource|The name of the entity, function, or action you want to use.|  
  
 The URL you will use will be composed with these parts: Protocol + Base URL + Web API path + Version + Resource.  
  
<a name="bkmk_version_compatibillity"></a>   
### Version compatibility  
 In this release we have applied a number of additive changes with each update or service pack. When these updates are applied they have added the same capabilities to subsequent minor versions. Because of this, if you can use version 8.2, then versions 8.1 and 8.0 will have the same capabilities. This is possible because all the changes have been additive or bug fixes addressing the items listed in [Microsoft Dynamics 365 Web API Limitations](../Topic/Microsoft%20Dynamics%20365%20Web%20API%20Limitations.md). No breaking changes were introduced.  
  
> [!NOTE]
>  The next major version (v9) introduces capabilities which are only available using that version. Subsequent minor versions may provide additional capabilities which will not be back ported to earlier minor versions. Your code written for v8.x will continue to work in v9.x when you reference `v8.2` in the URL you use.  
>   
>  For the v8.x release, use the latest version you can and know that updates or service packs within this major version will not introduce breaking changes. However, this will be different in future releases where you will need to pay more attention to the version of the service you address.  
  
<a name="bkmk_methods"></a>   
## HTTP methods  
 HTTP requests can apply a variety of different methods. When using the web API you will only use the methods listed in the following table.  
  
|Method|Usage|  
|------------|-----------|  
|GET|Use when retrieving data, including calling functions. The expected Status Code for a successful retrieve is                 200 OK.|  
|POST|Use when creating entities or calling actions.|  
|PATCH|Use when updating entities or performing upsert operations.|  
|DELETE|Use when deleting entities or individual properties of entities.|  
|PUT|Use in limited situations to update individual properties of entities. This method isn’t recommended when updating most entities. You’ll use this when updating model entities.|  
  
<a name="bkmk_headers"></a>   
## HTTP headers  
 Although the         ODataprotocol allows for both         JSONand         ATOMformat, the web API only supports         JSON. Therefore the following headers can be applied.  
  
 Every request should include the         Acceptheader value of         `application/json`, even when no response body is expected. Any error returned in the response will be returned as         JSON. While your code should work even if this header isn’t included, we recommend including it as a best practice  
  
 The current         ODataversion is 4.0, but future versions may allow for new capabilities. To ensure that there is no ambiguity about the         ODataversion that will be applied to your code at that point in the future, you should always include an explicit statement of the current         ODataversion and the Maximum version to apply in your code. Use both         OData-Versionand         OData-MaxVersionheaders set to a value of 4.0.  
  
 All HTTP headers should include at least the following headers.  
  
```  
Accept: application/json OData-MaxVersion: 4.0 OData-Version: 4.0  
```  
  
 Every request that includes         JSONdata in the request body must include a         Content-Typeheader with a value of         `application/json`.  
  
```  
Content-Type: application/json  
```  
  
 You can use additional headers to enable specific capabilities.  
  
-   To return data on create (             POST) or update (             PATCH) operations for entities, include the             `return=representation`preference. When this preference is applied to a             POSTrequest, a successful response will have status             201 (Created). For a             PATCHrequest, a successful response will have a status             200 (OK). Without this preference applied, both operations will return status             204 (No Content)to reflect that no data is returned in the body of the response by default.  
  
    > [!NOTE]
    >  This capability was added with               December 2016 update for Dynamics 365 (online and on-premises).  
  
-   To return formatted values with a query, include the             odata.include-annotationspreference set to             Microsoft.Dynamics.CRM.formattedvalueusing the             [Prefer](https://tools.ietf.org/html/rfc7240)header.             More information:[Include formatted values](../Topic/Query%20Data%20using%20the%20Web%20API.md#bkmk_includeFormattedValues)  
  
-   You also use the             Preferheader with the             odata.maxpagesizeoption to specify how many pages you want to return.             More information:[Specify the number of entities to return in a page](../Topic/Query%20Data%20using%20the%20Web%20API.md#bkmk_specifyNumber)  
  
-   To impersonate another user when the caller has the privileges to do so, add the             MSCRMCallerIDheader with the             systemuseridvalue of the user to impersonate.             More information:[Impersonate another user using the Web API](../Topic/Impersonate%20another%20user%20using%20the%20Web%20API.md).  
  
-   To apply optimistic concurrency, you can apply the             [If-Match](https://tools.ietf.org/html/rfc7232#section-3.1)header with an             Etagvalue.             More information:[Apply optimistic concurrency](../Topic/Perform%20conditional%20operations%20using%20the%20Web%20API.md#bkmk_Applyoptimisticconcurrency).  
  
-   To enable duplicate detection for a POST request, you can use the             MSCRM.SuppressDuplicateDetection: falseheader.             More information:[Check for Duplicate records](../Topic/Create%20an%20entity%20using%20the%20Web%20API.md#bkmk_SuppressDuplicateDetection)  
  
-   To control whether an upsert operation should actually create or update an entity, you can also use the             If-Matchand             [If-None-Match](https://tools.ietf.org/html/rfc7232#section-3.2)headers.             More information:[Upsert an entity](../Topic/Update%20and%20delete%20entities%20using%20the%20Web%20API.md#bkmk_upsert).  
  
-   When you execute batch operations, you must apply a number of different headers in the request and with each part sent in the body.             More information:[Execute batch operations using the Web API](../Topic/Execute%20batch%20operations%20using%20the%20Web%20API.md).  
  
<a name="bkmk_statusCodes"></a>   
## Identify status codes  
 Whether an http request succeeds or fails, the response will include a status code. Status codes returned by the         Microsoft Dynamics 365Web API include the following.  
  
|Code|Description|Type|  
|----------|-----------------|----------|  
|200 OK|Expect this when your operation will return data in the response body.|Success|  
|201 Created|Expect this when your entity                 POSToperation succeeds and you have specified the                 `return-representation`preference in your request. **Note:**  This capability was added with                   December 2016 update for Dynamics 365 (online and on-premises).|Success|  
|204 No Content|Expect this when your operation succeeds but does not return data in the response body.|Success|  
|304 Not Modified|Expect this when testing whether an entity has been modified since it was last retrieved.                 More information:[Conditional retrievals](../Topic/Perform%20conditional%20operations%20using%20the%20Web%20API.md#bkmk_DetectIfChanged)|Redirection|  
|403 Forbidden|Expect this for the following types of errors:<br /><br /> -   AccessDenied<br />-   AttributePermissionReadIsMissing<br />-   AttributePermissionUpdateIsMissingDuringUpdate<br />-   AttributePrivilegeCreateIsMissing<br />-   CannotActOnBehalfOfAnotherUser<br />-   CannotAddOrActonBehalfAnotherUserPrivilege<br />-   CrmSecurityError<br />-   InvalidAccessRights<br />-   PrincipalPrivilegeDenied<br />-   PrivilegeCreateIsDisabledForOrganization<br />-   PrivilegeDenied<br />-   unManagedinvalidprincipal<br />-   unManagedinvalidprivilegeedepth|Client Error|  
|401 Unauthorized|Expect this for the following types of errors:<br /><br /> -   BadAuthTicket<br />-   ExpiredAuthTicket<br />-   InsufficientAuthTicket<br />-   InvalidAuthTicket<br />-   InvalidUserAuth<br />-   MissingCrmAuthenticationToken<br />-   MissingCrmAuthenticationTokenOrganizationName<br />-   RequestIsNotAuthenticated<br />-   TamperedAuthTicket<br />-   UnauthorizedAccess<br />-   UnManagedInvalidSecurityPrincipal|Client Error|  
|413 Payload Too Large|Expect this when the request length is too large.|Client Error|  
|400 BadRequest|Expect this when an argument is invalid.|Client Error|  
|404 Not Found|Expect this when the resource doesn’t exist.|Client Error|  
|405 Method Not Allowed|This error occurs for incorrect method and resource combinations. For example, you can’t use                 DELETEor                 PATCHon a collection of entities.<br /><br /> Expect this for the following types of errors:<br /><br /> -   CannotDeleteDueToAssociation<br />-   InvalidOperation<br />-   NotSupported|Client Error|  
|412 Precondition Failed|Expect this for the following types of errors:<br /><br /> -   ConcurrencyVersionMismatch<br />-   DuplicateRecord|Client Error|  
|500 Internal Server Error|Expect this when a POST request to create an entity enables duplicate detection and the entity to create would be a duplicate.                 More information:[Check for Duplicate records](../Topic/Create%20an%20entity%20using%20the%20Web%20API.md#bkmk_SuppressDuplicateDetection)|Server Error|  
|501 Not Implemented|Expect this when some requested operation isnt implemented.|Server Error|  
|503 Service Unavailable|Expect this when the web API service isn’t available.|Server Error|  
  
<a name="bkmk_parseErrors"></a>   
## Parse errors from the response  
 Details about errors are included as         JSONin the response. Errors will be in this format.  
  
```json  
{ "error":{ "code": "  
        <This code is not related to the http status code and is frequently empty>", "message": "  
        <A message describing the error>", "innererror": { "message": "  
        <A message describing the error, this is frequently the same as the outer message>", "type": "Microsoft.Crm.CrmHttpException", "stacktrace": "  
        <Details from the server about where the error occurred>" } } }  
```  
  
## See Also  
 [Perform operations using the Web API](../Topic/Perform%20operations%20using%20the%20Web%20API.md)   
 [Query Data using the Web API](../Topic/Query%20Data%20using%20the%20Web%20API.md)   
 [Create an entity using the Web API](../Topic/Create%20an%20entity%20using%20the%20Web%20API.md)   
 [Retrieve an entity using the Web API](../Topic/Retrieve%20an%20entity%20using%20the%20Web%20API.md)   
 [Update and delete entities using the Web API](../Topic/Update%20and%20delete%20entities%20using%20the%20Web%20API.md)   
 [Associate and disassociate entities using the Web API](../Topic/Associate%20and%20disassociate%20entities%20using%20the%20Web%20API.md)   
 [Use Web API functions](../Topic/Use%20Web%20API%20functions.md)   
 [Use Web API actions](../Topic/Use%20Web%20API%20actions.md)   
 [Execute batch operations using the Web API](../Topic/Execute%20batch%20operations%20using%20the%20Web%20API.md)   
 [Impersonate another user using the Web API](../Topic/Impersonate%20another%20user%20using%20the%20Web%20API.md)   
 [Perform conditional operations using the Web API](../Topic/Perform%20conditional%20operations%20using%20the%20Web%20API.md)
