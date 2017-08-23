// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Information about a team member.</para>
    /// </summary>
    public class TeamMemberInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamMemberInfo> Encoder = new TeamMemberInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamMemberInfo> Decoder = new TeamMemberInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMemberInfo" /> class.</para>
        /// </summary>
        /// <param name="profile">Profile of a user as a member of a team.</param>
        /// <param name="role">The user's role in the team.</param>
        public TeamMemberInfo(TeamMemberProfile profile,
                              AdminTier role)
        {
            if (profile == null)
            {
                throw new sys.ArgumentNullException("profile");
            }

            if (role == null)
            {
                throw new sys.ArgumentNullException("role");
            }

            this.Profile = profile;
            this.Role = role;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMemberInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamMemberInfo()
        {
        }

        /// <summary>
        /// <para>Profile of a user as a member of a team.</para>
        /// </summary>
        public TeamMemberProfile Profile { get; protected set; }

        /// <summary>
        /// <para>The user's role in the team.</para>
        /// </summary>
        public AdminTier Role { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamMemberInfo" />.</para>
        /// </summary>
        private class TeamMemberInfoEncoder : enc.StructEncoder<TeamMemberInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamMemberInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("profile", value.Profile, writer, global::Dropbox.Api.Team.TeamMemberProfile.Encoder);
                WriteProperty("role", value.Role, writer, global::Dropbox.Api.Team.AdminTier.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamMemberInfo" />.</para>
        /// </summary>
        private class TeamMemberInfoDecoder : enc.StructDecoder<TeamMemberInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamMemberInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamMemberInfo Create()
            {
                return new TeamMemberInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamMemberInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "profile":
                        value.Profile = global::Dropbox.Api.Team.TeamMemberProfile.Decoder.Decode(reader);
                        break;
                    case "role":
                        value.Role = global::Dropbox.Api.Team.AdminTier.Decoder.Decode(reader);
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