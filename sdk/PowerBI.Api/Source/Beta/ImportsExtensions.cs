// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class ImportsExtensions
    {
            /// <summary>
            /// Returns the Imports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            public static ODataResponseListImport GetImports(this IImports operations, string collectionName, string workspaceId)
            {
                return Task.Factory.StartNew(s => ((IImports)s).GetImportsAsync(collectionName, workspaceId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Imports
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListImport> GetImportsAsync( this IImports operations, string collectionName, string workspaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportsWithHttpMessagesAsync(collectionName, workspaceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new import
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            public static Import PostImport(this IImports operations, string collectionName, string workspaceId, ImportInfo importInfo)
            {
                return Task.Factory.StartNew(s => ((IImports)s).PostImportAsync(collectionName, workspaceId, importInfo), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new import
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='importInfo'>
            /// The import to post
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> PostImportAsync( this IImports operations, string collectionName, string workspaceId, ImportInfo importInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostImportWithHttpMessagesAsync(collectionName, workspaceId, importInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the import by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='importId'>
            /// The import id
            /// </param>
            public static Import GetImportById(this IImports operations, string collectionName, string workspaceId, string importId)
            {
                return Task.Factory.StartNew(s => ((IImports)s).GetImportByIdAsync(collectionName, workspaceId, importId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the import by id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='collectionName'>
            /// The workspace collection name
            /// </param>
            /// <param name='workspaceId'>
            /// The workspace id
            /// </param>
            /// <param name='importId'>
            /// The import id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Import> GetImportByIdAsync( this IImports operations, string collectionName, string workspaceId, string importId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetImportByIdWithHttpMessagesAsync(collectionName, workspaceId, importId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}