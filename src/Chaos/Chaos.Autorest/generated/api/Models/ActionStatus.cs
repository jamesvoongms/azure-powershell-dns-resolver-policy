// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents the an action and its status.</summary>
    public partial class ActionStatus :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatus,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatusInternal
    {

        /// <summary>Backing field for <see cref="ActionId" /> property.</summary>
        private string _actionId;

        /// <summary>The id of the action status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ActionId { get => this._actionId; }

        /// <summary>Backing field for <see cref="ActionName" /> property.</summary>
        private string _actionName;

        /// <summary>The name of the action status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ActionName { get => this._actionName; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>String that represents the end time of the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Internal Acessors for ActionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatusInternal.ActionId { get => this._actionId; set { {_actionId = value;} } }

        /// <summary>Internal Acessors for ActionName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatusInternal.ActionName { get => this._actionName; set { {_actionName = value;} } }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatusInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatusInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatusInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionActionTargetDetailsProperties> Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IActionStatusInternal.Target { get => this._target; set { {_target = value;} } }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>String that represents the start time of the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionActionTargetDetailsProperties> _target;

        /// <summary>The array of targets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionActionTargetDetailsProperties> Target { get => this._target; }

        /// <summary>Creates an new <see cref="ActionStatus" /> instance.</summary>
        public ActionStatus()
        {

        }
    }
    /// Model that represents the an action and its status.
    public partial interface IActionStatus :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>The id of the action status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The id of the action status.",
        SerializedName = @"actionId",
        PossibleTypes = new [] { typeof(string) })]
        string ActionId { get;  }
        /// <summary>The name of the action status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the action status.",
        SerializedName = @"actionName",
        PossibleTypes = new [] { typeof(string) })]
        string ActionName { get;  }
        /// <summary>String that represents the end time of the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the end time of the action.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>String that represents the start time of the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the start time of the action.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>The status of the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the action.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }
        /// <summary>The array of targets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The array of targets.",
        SerializedName = @"targets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionActionTargetDetailsProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionActionTargetDetailsProperties> Target { get;  }

    }
    /// Model that represents the an action and its status.
    internal partial interface IActionStatusInternal

    {
        /// <summary>The id of the action status.</summary>
        string ActionId { get; set; }
        /// <summary>The name of the action status.</summary>
        string ActionName { get; set; }
        /// <summary>String that represents the end time of the action.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>String that represents the start time of the action.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The status of the action.</summary>
        string Status { get; set; }
        /// <summary>The array of targets.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionActionTargetDetailsProperties> Target { get; set; }

    }
}