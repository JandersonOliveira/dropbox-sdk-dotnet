// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The metadata which includes basic information about the shared folder.</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Sharing.SharedFolderMetadataBase" />
    public class SharedFolderMetadata : SharedFolderMetadataBase
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderMetadata> Encoder = new SharedFolderMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderMetadata> Decoder = new SharedFolderMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="accessType">The current user's access level for this shared
        /// folder.</param>
        /// <param name="isTeamFolder">Whether this folder is a <a
        /// href="https://www.dropbox.com/en/help/986">team folder</a>.</param>
        /// <param name="policy">Policies governing this shared folder.</param>
        /// <param name="name">The name of the this shared folder.</param>
        /// <param name="sharedFolderId">The ID of the shared folder.</param>
        /// <param name="timeInvited">Timestamp indicating when the current user was invited to
        /// this shared folder.</param>
        /// <param name="ownerTeam">The team that owns the folder. This field is not present if
        /// the folder is not owned by a team.</param>
        /// <param name="parentSharedFolderId">The ID of the parent shared folder. This field
        /// is present only if the folder is contained within another shared folder.</param>
        /// <param name="pathLower">The lower-cased full path of this shared folder. Absent for
        /// unmounted folders.</param>
        /// <param name="permissions">Actions the current user may perform on the folder and
        /// its contents. The set of permissions corresponds to the FolderActions in the
        /// request.</param>
        public SharedFolderMetadata(AccessLevel accessType,
                                    bool isTeamFolder,
                                    FolderPolicy policy,
                                    string name,
                                    string sharedFolderId,
                                    sys.DateTime timeInvited,
                                    Dropbox.Api.Users.Team ownerTeam = null,
                                    string parentSharedFolderId = null,
                                    string pathLower = null,
                                    col.IEnumerable<FolderPermission> permissions = null)
            : base(accessType, isTeamFolder, policy, ownerTeam, parentSharedFolderId)
        {
            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (sharedFolderId == null)
            {
                throw new sys.ArgumentNullException("sharedFolderId");
            }
            if (!re.Regex.IsMatch(sharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("sharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
            }

            var permissionsList = enc.Util.ToList(permissions);

            this.Name = name;
            this.SharedFolderId = sharedFolderId;
            this.TimeInvited = timeInvited;
            this.PathLower = pathLower;
            this.Permissions = permissionsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public SharedFolderMetadata()
        {
        }

        /// <summary>
        /// <para>The name of the this shared folder.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>The ID of the shared folder.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        /// <summary>
        /// <para>Timestamp indicating when the current user was invited to this shared
        /// folder.</para>
        /// </summary>
        public sys.DateTime TimeInvited { get; protected set; }

        /// <summary>
        /// <para>The lower-cased full path of this shared folder. Absent for unmounted
        /// folders.</para>
        /// </summary>
        public string PathLower { get; protected set; }

        /// <summary>
        /// <para>Actions the current user may perform on the folder and its contents. The set
        /// of permissions corresponds to the FolderActions in the request.</para>
        /// </summary>
        public col.IList<FolderPermission> Permissions { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderMetadata" />.</para>
        /// </summary>
        private class SharedFolderMetadataEncoder : enc.StructEncoder<SharedFolderMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, Dropbox.Api.Sharing.AccessLevel.Encoder);
                WriteProperty("is_team_folder", value.IsTeamFolder, writer, enc.BooleanEncoder.Instance);
                WriteProperty("policy", value.Policy, writer, Dropbox.Api.Sharing.FolderPolicy.Encoder);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
                WriteProperty("time_invited", value.TimeInvited, writer, enc.DateTimeEncoder.Instance);
                if (value.OwnerTeam != null)
                {
                    WriteProperty("owner_team", value.OwnerTeam, writer, Dropbox.Api.Users.Team.Encoder);
                }
                if (value.ParentSharedFolderId != null)
                {
                    WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                }
                if (value.PathLower != null)
                {
                    WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                }
                if (value.Permissions.Count > 0)
                {
                    WriteListProperty("permissions", value.Permissions, writer, Dropbox.Api.Sharing.FolderPermission.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderMetadata" />.</para>
        /// </summary>
        private class SharedFolderMetadataDecoder : enc.StructDecoder<SharedFolderMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderMetadata Create()
            {
                return new SharedFolderMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "is_team_folder":
                        value.IsTeamFolder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "policy":
                        value.Policy = Dropbox.Api.Sharing.FolderPolicy.Decoder.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "time_invited":
                        value.TimeInvited = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "owner_team":
                        value.OwnerTeam = Dropbox.Api.Users.Team.Decoder.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "permissions":
                        value.Permissions = ReadList<FolderPermission>(reader, Dropbox.Api.Sharing.FolderPermission.Decoder);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}