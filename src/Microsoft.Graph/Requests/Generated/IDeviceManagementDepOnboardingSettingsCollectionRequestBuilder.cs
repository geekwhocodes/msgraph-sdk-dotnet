// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceManagementDepOnboardingSettingsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementDepOnboardingSettingsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementDepOnboardingSettingsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementDepOnboardingSettingsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDepOnboardingSettingRequestBuilder"/> for the specified DepOnboardingSetting.
        /// </summary>
        /// <param name="id">The ID for the DepOnboardingSetting.</param>
        /// <returns>The <see cref="IDepOnboardingSettingRequestBuilder"/>.</returns>
        IDepOnboardingSettingRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingUploadDepToken.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingUploadDepTokenRequestBuilder"/>.</returns>
        IDepOnboardingSettingUploadDepTokenRequestBuilder UploadDepToken(
            string appleId = null,
            string depToken = null);

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingSyncWithAppleDeviceEnrollmentProgram.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingSyncWithAppleDeviceEnrollmentProgramRequestBuilder"/>.</returns>
        IDepOnboardingSettingSyncWithAppleDeviceEnrollmentProgramRequestBuilder SyncWithAppleDeviceEnrollmentProgram();

        /// <summary>
        /// Gets the request builder for DepOnboardingSettingGetEncryptionPublicKey.
        /// </summary>
        /// <returns>The <see cref="IDepOnboardingSettingGetEncryptionPublicKeyRequestBuilder"/>.</returns>
        IDepOnboardingSettingGetEncryptionPublicKeyRequestBuilder GetEncryptionPublicKey();
    }
}
