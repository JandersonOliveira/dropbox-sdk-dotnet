// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Followed or unfollowed a Paper doc or folder.</para>
    /// </summary>
    public class PaperContentChangeSubscriptionDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperContentChangeSubscriptionDetails> Encoder = new PaperContentChangeSubscriptionDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperContentChangeSubscriptionDetails> Decoder = new PaperContentChangeSubscriptionDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PaperContentChangeSubscriptionDetails" /> class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        /// <param name="newSubscriptionLevel">New subscription level.</param>
        /// <param name="previousSubscriptionLevel">Previous subscription level. Might be
        /// missing due to historical data gap.</param>
        public PaperContentChangeSubscriptionDetails(string eventUuid,
                                                     PaperTaggedValue newSubscriptionLevel,
                                                     PaperTaggedValue previousSubscriptionLevel = null)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            if (newSubscriptionLevel == null)
            {
                throw new sys.ArgumentNullException("newSubscriptionLevel");
            }

            this.EventUuid = eventUuid;
            this.NewSubscriptionLevel = newSubscriptionLevel;
            this.PreviousSubscriptionLevel = previousSubscriptionLevel;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="PaperContentChangeSubscriptionDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperContentChangeSubscriptionDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        /// <summary>
        /// <para>New subscription level.</para>
        /// </summary>
        public PaperTaggedValue NewSubscriptionLevel { get; protected set; }

        /// <summary>
        /// <para>Previous subscription level. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public PaperTaggedValue PreviousSubscriptionLevel { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperContentChangeSubscriptionDetails" />.</para>
        /// </summary>
        private class PaperContentChangeSubscriptionDetailsEncoder : enc.StructEncoder<PaperContentChangeSubscriptionDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperContentChangeSubscriptionDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
                WriteProperty("new_subscription_level", value.NewSubscriptionLevel, writer, global::Dropbox.Api.TeamLog.PaperTaggedValue.Encoder);
                if (value.PreviousSubscriptionLevel != null)
                {
                    WriteProperty("previous_subscription_level", value.PreviousSubscriptionLevel, writer, global::Dropbox.Api.TeamLog.PaperTaggedValue.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperContentChangeSubscriptionDetails" />.</para>
        /// </summary>
        private class PaperContentChangeSubscriptionDetailsDecoder : enc.StructDecoder<PaperContentChangeSubscriptionDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="PaperContentChangeSubscriptionDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperContentChangeSubscriptionDetails Create()
            {
                return new PaperContentChangeSubscriptionDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperContentChangeSubscriptionDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_subscription_level":
                        value.NewSubscriptionLevel = global::Dropbox.Api.TeamLog.PaperTaggedValue.Decoder.Decode(reader);
                        break;
                    case "previous_subscription_level":
                        value.PreviousSubscriptionLevel = global::Dropbox.Api.TeamLog.PaperTaggedValue.Decoder.Decode(reader);
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
