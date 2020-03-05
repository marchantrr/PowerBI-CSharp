// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ImportsOperations operations.
    /// </summary>
    public partial interface IImportsOperations
    {
        /// <summary>
        /// Returns a list of imports from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or
        /// Dataset.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Imports>> GetImportsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates new content on **"My Workspace"** from .pbix, Excel, Rdl or
        /// file path in OneDrive for Business.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file,
        /// request Headers should include **Content-Type:
        /// multipart/form-data** with the file [encoded as form
        /// data](https://www.w3.org/TR/html401/interact/forms.html) in the
        /// request body. &lt;/li&gt;&lt;li&gt;To import xlsx file from
        /// OneDrive for Business, request Headers should include
        /// **Content-Type: application/json** with
        /// [ImportInfo](/rest/api/power-bi/imports/postimport#importinfo) in
        /// the request body.&lt;/li&gt;&lt;li&gt;Import .pbix file from
        /// OneDrive is not supported.&lt;/li&gt;&lt;li&gt;To import large
        /// .pbix files between 1 GB and 10 GB, see [Create Temporary Upload
        /// Location](/rest/api/power-bi/imports/createtemporaryuploadlocation),
        /// supported only for workspaces on premium
        /// capacity.&lt;/li&gt;&lt;/ul&gt;
        /// </remarks>
        /// <param name='datasetDisplayName'>
        /// The display name of the dataset, should include file extension. Not
        /// supported when importing from OneDrive for Business.
        /// </param>
        /// <param name='importInfo'>
        /// The import to post
        /// </param>
        /// <param name='nameConflict'>
        /// Determines what to do if a dataset with the same name already
        /// exists. Default value is 'Ignore'.&lt;br/&gt;Only Abort and
        /// Overwrite are supported with Rdl files. Possible values include:
        /// 'Ignore', 'Abort', 'Overwrite', 'CreateOrOverwrite',
        /// 'GenerateUniqueName'
        /// </param>
        /// <param name='skipReport'>
        /// Determines whether to skip report import, if specified value must
        /// be 'true'. Only supported for PBIX files.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Import>> PostImportWithHttpMessagesAsync(string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified import from **"My Workspace"**.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or
        /// Dataset.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='importId'>
        /// The import id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Import>> GetImportWithHttpMessagesAsync(System.Guid importId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a temporary blob storage to be used to import large .pbix
        /// files larger than 1 GB and up to 10 GB.
        /// </summary>
        /// <remarks>
        /// To import large .pbix files, create a temporary upload location and
        /// upload the .pbix file using the shared access signature (SAS) url
        /// from the response, and then call [Post
        /// Import](/rest/api/power-bi/imports/postimport) and specify
        /// 'fileUrl' to be the SAS url in the [Request
        /// Body](/rest/api/power-bi/imports/postimport#request-body)&lt;br/&gt;&lt;br/&gt;**Note**:
        /// Import large .pbix files is only available for workspaces on
        /// premium capacity and for .pbix files that are between 1 GB and 10
        /// GB. &lt;br/&gt;&lt;br/&gt;**Required scope**: Dataset.ReadWrite.All
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<TemporaryUploadLocation>> CreateTemporaryUploadLocationWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of imports from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or
        /// Dataset.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;li&gt;Import
        /// .pbix file from OneDrive is not supported.&lt;/li&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Imports>> GetImportsInGroupWithHttpMessagesAsync(System.Guid groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates new content on the specified workspace from .pbix, .json,
        /// Excel, Rdl, or file path in OneDrive for Business.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h3&gt;Notes&lt;/h3&gt;&lt;ul&gt;&lt;li&gt;To import a file,
        /// request Headers should include **Content-Type:
        /// multipart/form-data** with the file [encoded as form
        /// data](https://www.w3.org/TR/html401/interact/forms.html) in the
        /// request body &lt;/li&gt;&lt;li&gt;To import from OneDrive for
        /// Business, request Headers should include **Content-Type:
        /// application/json** with
        /// [ImportInfo](/rest/api/power-bi/imports/postimportingroup#importinfo)
        /// in the request body.&lt;/li&gt;&lt;li&gt;To import large .pbix
        /// files between 1 GB and 10 GB see [Create Temporary Upload Location
        /// In
        /// Group](/rest/api/power-bi/imports/createtemporaryuploadlocationingroup),
        /// supported only for workspaces on premium
        /// capacity.&lt;/li&gt;&lt;li&gt;To create a dataflow from a
        /// model.json, specify the parameter datasetDisplayName as described
        /// below.&lt;/li&gt;&lt;/ul&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='datasetDisplayName'>
        /// The display name of the dataset should include file extension. Not
        /// supported when importing from OneDrive for Business. For importing
        /// or creating dataflows, this parameter should be hardcoded to
        /// model.json.
        /// </param>
        /// <param name='importInfo'>
        /// The import to post
        /// </param>
        /// <param name='nameConflict'>
        /// Determines what to do if a dataset with the same name already
        /// exists. Default value is 'Ignore'.&lt;br/&gt;Only Abort and
        /// Overwrite are supported with Rdl files.&lt;br/&gt;Only Abort and
        /// GenerateUniqueName are supported with dataflow model.json files.
        /// Possible values include: 'Ignore', 'Abort', 'Overwrite',
        /// 'CreateOrOverwrite', 'GenerateUniqueName'
        /// </param>
        /// <param name='skipReport'>
        /// Determines whether to skip report import, if specified value must
        /// be 'true'. Only supported for PBIX files.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Import>> PostImportInGroupWithHttpMessagesAsync(System.Guid groupId, string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified import from the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Dataset.ReadWrite.All or
        /// Dataset.Read.All &lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='importId'>
        /// The import id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Import>> GetImportInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid importId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a temporary blob storage to be used to import large .pbix
        /// files larger than 1 GB and up to 10 GB.
        /// </summary>
        /// <remarks>
        /// To import large .pbix files, create a temporary upload location and
        /// upload the .pbix file using the shared access signature (SAS) url
        /// from the response, and then call [Post Import In
        /// Group](/rest/api/power-bi/imports/postimportingroup) and specify
        /// 'fileUrl' to be the SAS url in the [Request
        /// Body](/rest/api/power-bi/imports/postimportingroup#request-body).&lt;br/&gt;&lt;br/&gt;**Note**:
        /// Import large .pbix files is only available for workspaces on
        /// premium capacity and for .pbix files that is between 1 GB and 10
        /// GB. &lt;br/&gt;&lt;br/&gt;**Required scope**: Dataset.ReadWrite.All
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<TemporaryUploadLocation>> CreateTemporaryUploadLocationInGroupWithHttpMessagesAsync(System.Guid groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of imports for the organization.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Imports>> GetImportsAsAdminWithHttpMessagesAsync(string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}