// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Booking Business.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class BookingBusiness : BookingNamedEntity
    {
    
        /// <summary>
        /// Gets or sets business type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessType", Required = Newtonsoft.Json.Required.Default)]
        public string BusinessType { get; set; }
    
        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddress Address { get; set; }
    
        /// <summary>
        /// Gets or sets phone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phone", Required = Newtonsoft.Json.Required.Default)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email", Required = Newtonsoft.Json.Required.Default)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets web site url.
        /// Example: https://www.contoso.com
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webSiteUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebSiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets default currency iso.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultCurrencyIso", Required = Newtonsoft.Json.Required.Default)]
        public string DefaultCurrencyIso { get; set; }
    
        /// <summary>
        /// Gets or sets business hours.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessHours", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<BookingWorkHours> BusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets scheduling policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schedulingPolicy", Required = Newtonsoft.Json.Required.Default)]
        public BookingSchedulingPolicy SchedulingPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets is published.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isPublished", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsPublished { get; set; }
    
        /// <summary>
        /// Gets or sets public url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publicUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PublicUrl { get; set; }
    
        /// <summary>
        /// Gets or sets appointments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appointments", Required = Newtonsoft.Json.Required.Default)]
        public IBookingBusinessAppointmentsCollectionPage Appointments { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarView", Required = Newtonsoft.Json.Required.Default)]
        public IBookingBusinessCalendarViewCollectionPage CalendarView { get; set; }
    
        /// <summary>
        /// Gets or sets customers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customers", Required = Newtonsoft.Json.Required.Default)]
        public IBookingBusinessCustomersCollectionPage Customers { get; set; }
    
        /// <summary>
        /// Gets or sets services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "services", Required = Newtonsoft.Json.Required.Default)]
        public IBookingBusinessServicesCollectionPage Services { get; set; }
    
        /// <summary>
        /// Gets or sets staff members.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "staffMembers", Required = Newtonsoft.Json.Required.Default)]
        public IBookingBusinessStaffMembersCollectionPage StaffMembers { get; set; }
    
    }
}

