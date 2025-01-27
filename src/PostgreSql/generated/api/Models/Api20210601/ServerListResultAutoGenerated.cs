namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>A list of servers.</summary>
    public partial class ServerListResultAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerListResultAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerListResultAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerAutoGenerated[] _value;

        /// <summary>The list of flexible servers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerAutoGenerated[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ServerListResultAutoGenerated" /> instance.</summary>
        public ServerListResultAutoGenerated()
        {

        }
    }
    /// A list of servers.
    public partial interface IServerListResultAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link used to get the next page of operations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of flexible servers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of flexible servers",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerAutoGenerated) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerAutoGenerated[] Value { get; set; }

    }
    /// A list of servers.
    internal partial interface IServerListResultAutoGeneratedInternal

    {
        /// <summary>The link used to get the next page of operations.</summary>
        string NextLink { get; set; }
        /// <summary>The list of flexible servers</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerAutoGenerated[] Value { get; set; }

    }
}