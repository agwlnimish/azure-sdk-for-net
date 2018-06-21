// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for AccountsOperations.
    /// </summary>
    public static partial class AccountsOperationsExtensions
    {
        /// <summary>
        /// Tests whether the specified Azure Storage account is linked to the given Data
        /// Lake Analytics account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to test
        /// Azure storage account existence.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account for which to test for existence.
        /// </param>
        public static bool StorageAccountExists(this IAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName)
        {
            return Task.Factory.StartNew(s => ((IAccountsOperations)s).StorageAccountExistsAsync(resourceGroupName, accountName, storageAccountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tests whether the specified Azure Storage account is linked to the given Data
        /// Lake Analytics account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to test
        /// Azure storage account existence.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account for which to test for existence.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<bool> StorageAccountExistsAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.StorageAccountExistsWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Tests the existence of the specified Azure Storage container associated with the
        /// given Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account for which to retrieve
        /// blob container.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account from which to test the
        /// blob container's existence.
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container to test for existence.
        /// </param>
        public static bool StorageContainerExists(this IAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, string containerName)
        {
            return Task.Factory.StartNew(s => ((IAccountsOperations)s).StorageContainerExistsAsync(resourceGroupName, accountName, storageAccountName, containerName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tests the existence of the specified Azure Storage container associated with the
        /// given Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account for which to retrieve
        /// blob container.
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account from which to test the
        /// blob container's existence.
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container to test for existence.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<bool> StorageContainerExistsAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, string storageAccountName, string containerName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.StorageContainerExistsWithHttpMessagesAsync(resourceGroupName, accountName, storageAccountName, containerName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Tests whether the specified Data Lake Store account is linked to the
        /// specified Data Lake Analytics account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to test
        /// the existence of the Data Lake Store account.
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the Data Lake Store account to test for existence
        /// </param>
        public static bool DataLakeStoreAccountExists(this IAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName)
        {
            return Task.Factory.StartNew(s => ((IAccountsOperations)s).DataLakeStoreAccountExistsAsync(resourceGroupName, accountName, dataLakeStoreAccountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tests whether the specified Data Lake Store account is linked to the
        /// specified Data Lake Analytics account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to test
        /// the existence of the Data Lake Store account.
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the Data Lake Store account to test for existence
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<bool> DataLakeStoreAccountExistsAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.DataLakeStoreAccountExistsWithHttpMessagesAsync(resourceGroupName, accountName, dataLakeStoreAccountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Tests for the existence of the specified Data Lake Analytics account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to test existence of.
        /// </param>
        public static bool Exists(this IAccountsOperations operations, string resourceGroupName, string accountName)
        {
            return Task.Factory.StartNew(s => ((IAccountsOperations)s).ExistsAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tests for the existence of the specified Data Lake Analytics account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to test existence of.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<bool> ExistsAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ExistsWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
