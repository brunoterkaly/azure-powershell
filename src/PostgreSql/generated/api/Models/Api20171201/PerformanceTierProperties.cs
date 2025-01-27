namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>Performance tier properties</summary>
    public partial class PerformanceTierProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierProperties,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ID of the performance tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="MaxBackupRetentionDay" /> property.</summary>
        private int? _maxBackupRetentionDay;

        /// <summary>Maximum Backup retention in days for the performance tier edition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? MaxBackupRetentionDay { get => this._maxBackupRetentionDay; set => this._maxBackupRetentionDay = value; }

        /// <summary>Backing field for <see cref="MaxLargeStorageMb" /> property.</summary>
        private int? _maxLargeStorageMb;

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? MaxLargeStorageMb { get => this._maxLargeStorageMb; set => this._maxLargeStorageMb = value; }

        /// <summary>Backing field for <see cref="MaxStorageMb" /> property.</summary>
        private int? _maxStorageMb;

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? MaxStorageMb { get => this._maxStorageMb; set => this._maxStorageMb = value; }

        /// <summary>Backing field for <see cref="MinBackupRetentionDay" /> property.</summary>
        private int? _minBackupRetentionDay;

        /// <summary>Minimum Backup retention in days for the performance tier edition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? MinBackupRetentionDay { get => this._minBackupRetentionDay; set => this._minBackupRetentionDay = value; }

        /// <summary>Backing field for <see cref="MinLargeStorageMb" /> property.</summary>
        private int? _minLargeStorageMb;

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? MinLargeStorageMb { get => this._minLargeStorageMb; set => this._minLargeStorageMb = value; }

        /// <summary>Backing field for <see cref="MinStorageMb" /> property.</summary>
        private int? _minStorageMb;

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? MinStorageMb { get => this._minStorageMb; set => this._minStorageMb = value; }

        /// <summary>Backing field for <see cref="ServiceLevelObjective" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierServiceLevelObjectives[] _serviceLevelObjective;

        /// <summary>Service level objectives associated with the performance tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierServiceLevelObjectives[] ServiceLevelObjective { get => this._serviceLevelObjective; set => this._serviceLevelObjective = value; }

        /// <summary>Creates an new <see cref="PerformanceTierProperties" /> instance.</summary>
        public PerformanceTierProperties()
        {

        }
    }
    /// Performance tier properties
    public partial interface IPerformanceTierProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>ID of the performance tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the performance tier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Maximum Backup retention in days for the performance tier edition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum Backup retention in days for the performance tier edition",
        SerializedName = @"maxBackupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxBackupRetentionDay { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"maxLargeStorageMB",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxLargeStorageMb { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"maxStorageMB",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxStorageMb { get; set; }
        /// <summary>Minimum Backup retention in days for the performance tier edition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum Backup retention in days for the performance tier edition",
        SerializedName = @"minBackupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? MinBackupRetentionDay { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"minLargeStorageMB",
        PossibleTypes = new [] { typeof(int) })]
        int? MinLargeStorageMb { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"minStorageMB",
        PossibleTypes = new [] { typeof(int) })]
        int? MinStorageMb { get; set; }
        /// <summary>Service level objectives associated with the performance tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service level objectives associated with the performance tier",
        SerializedName = @"serviceLevelObjectives",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierServiceLevelObjectives) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierServiceLevelObjectives[] ServiceLevelObjective { get; set; }

    }
    /// Performance tier properties
    internal partial interface IPerformanceTierPropertiesInternal

    {
        /// <summary>ID of the performance tier.</summary>
        string Id { get; set; }
        /// <summary>Maximum Backup retention in days for the performance tier edition</summary>
        int? MaxBackupRetentionDay { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        int? MaxLargeStorageMb { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        int? MaxStorageMb { get; set; }
        /// <summary>Minimum Backup retention in days for the performance tier edition</summary>
        int? MinBackupRetentionDay { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        int? MinLargeStorageMb { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        int? MinStorageMb { get; set; }
        /// <summary>Service level objectives associated with the performance tier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IPerformanceTierServiceLevelObjectives[] ServiceLevelObjective { get; set; }

    }
}