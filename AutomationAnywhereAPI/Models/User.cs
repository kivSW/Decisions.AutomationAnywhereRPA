﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutomationAnywhereAPI.Models
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "domain")]
        public object Domain { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "version")]
        public int Version { get; set; }

        [DataMember(Name = "principalId")]
        public int PrincipalId { get; set; }

        [DataMember(Name = "deleted")]
        public bool Deleted { get; set; }

        [DataMember(Name = "roles")]
        public Role[] Roles { get; set; }

        [DataMember(Name = "sysAssignedRoles")]
        public object[] SysAssignedRoles { get; set; }

        [DataMember(Name = "groupNames")]
        public object[] GroupNames { get; set; }

        [DataMember(Name = "permissions")]
        public object[] Permissions { get; set; }

        [DataMember(Name = "licenseFeatures")]
        public string[] LicenseFeatures { get; set; }

        [DataMember(Name = "emailVerified")]
        public bool EmailVerified { get; set; }

        [DataMember(Name = "passwordSet")]
        public bool PasswordSet { get; set; }

        [DataMember(Name = "questionsSet")]
        public bool QuestionsSet { get; set; }

        [DataMember(Name = "enableAutoLogin")]
        public bool EnableAutoLogin { get; set; }

        [DataMember(Name = "disabled")]
        public bool Disabled { get; set; }

        [DataMember(Name = "clientRegistered")]
        public bool ClientRegistered { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "createdBy")]
        public int CreatedBy { get; set; }

        [DataMember(Name = "createdOn")]
        public DateTime CreatedOn { get; set; }

        [DataMember(Name = "updatedBy")]
        public int UpdatedBy { get; set; }

        [DataMember(Name = "updatedOn")]
        public DateTime UpdatedOn { get; set; }

        [DataMember(Name = "publicKey")]
        public object PublicKey { get; set; }

        [DataMember(Name = "appType")]
        public object AppType { get; set; }

        [DataMember(Name = "routingName")]
        public object RoutingName { get; set; }

        [DataMember(Name = "appUrl")]
        public object AppUrl { get; set; }
    }
}
