namespace Experimental.System.Messaging
{
    internal static class Res
    {
        internal const string MSMQNotInstalled = "MSMQNotInstalled";

        internal const string TooManyColumns = "TooManyColumns";

        internal const string PlatformNotSupported = "PlatformNotSupported";

        internal const string MSMQInfoNotSupported = "MSMQInfoNotSupported";

        internal const string InfiniteValue = "InfiniteValue";

        internal const string InvalidTrustee = "InvalidTrustee";

        internal const string InvalidTrusteeName = "InvalidTrusteeName";

        internal const string CouldntResolve = "CouldntResolve";

        internal const string CouldntResolveName = "CouldntResolveName";

        internal const string DefaultSizeError = "DefaultSizeError";

        internal const string PathSyntax = "PathSyntax";

        internal const string InvalidParameter = "InvalidParameter";

        internal const string InvalidXmlFormat = "InvalidXmlFormat";

        internal const string CriteriaNotDefined = "CriteriaNotDefined";

        internal const string InvalidDateValue = "InvalidDateValue";

        internal const string InvalidProperty = "InvalidProperty";

        internal const string NoCurrentMessageQueue = "NoCurrentMessageQueue";

        internal const string LongQueueName = "LongQueueName";

        internal const string TransactionNotStarted = "TransactionNotStarted";

        internal const string TransactionStarted = "TransactionStarted";

        internal const string StoredObjectsNotSupported = "StoredObjectsNotSupported";

        internal const string InvalidTypeDeserialization = "InvalidTypeDeserialization";

        internal const string InvalidTypeSerialization = "InvalidTypeSerialization";

        internal const string IncorrectNumberOfBytes = "IncorrectNumberOfBytes";

        internal const string NotImplemented = "NotImplemented";

        internal const string NotAcknowledgement = "NotAcknowledgement";

        internal const string MissingProperty = "MissingProperty";

        internal const string ArrivedTimeNotSet = "ArrivedTimeNotSet";

        internal const string AuthenticationNotSet = "AuthenticationNotSet";

        internal const string FormatterMissing = "FormatterMissing";

        internal const string DestinationQueueNotSet = "DestinationQueueNotSet";

        internal const string IdNotSet = "IdNotSet";

        internal const string LookupIdNotSet = "LookupIdNotSet";

        internal const string MessageTypeNotSet = "MessageTypeNotSet";

        internal const string SenderIdNotSet = "SenderIdNotSet";

        internal const string VersionNotSet = "VersionNotSet";

        internal const string SentTimeNotSet = "SentTimeNotSet";

        internal const string SourceMachineNotSet = "SourceMachineNotSet";

        internal const string InvalidId = "InvalidId";

        internal const string TypeListMissing = "TypeListMissing";

        internal const string InvalidLabel = "InvalidLabel";

        internal const string AmbiguousLabel = "AmbiguousLabel";

        internal const string InvalidQueuePathToCreate = "InvalidQueuePathToCreate";

        internal const string AsyncResultInvalid = "AsyncResultInvalid";

        internal const string QueueExistsError = "QueueExistsError";

        internal const string NoCurrentMessage = "NoCurrentMessage";

        internal const string NotSet = "NotSet";

        internal const string MessageNotFound = "MessageNotFound";

        internal const string UnknownError = "UnknownError";

        internal const string toStringNone = "(none)";

        internal const string MsgAcknowledgement = "Gets the classification of acknowledgment that this message represents.";

        internal const string MsgAcknowledgeType = "Specifies the type of acknowledgment messages the system posts (in the administration queue) and when acknowledgments are returned.";

        internal const string MsgAdministrationQueue = "Specifies the administration queue used for system-generated acknowledgment.";

        internal const string MsgAppSpecific = "Specifies application-generated information such as single integer values or application-defined message classes.";

        internal const string MsgArrivedTime = "Indicates when the message arrived at the queue.";

        internal const string MsgAttachSenderId = "Indicates if the SenderId is to be or has been attached to the message.";

        internal const string MsgAuthenticated = "Used by the receiving application when trying to determine if authentication was requested. If authentication was requested and the message is in the queue, then the message was authenticated.";

        internal const string MsgAuthenticationProviderName = "Specifies the name of the cryptographic provider used to generate the digital signature of the message.";

        internal const string MsgAuthenticationProviderType = "Specifies the type of cryptographic provider used to generate the digital signature of the message.";

        internal const string MsgBody = "Represents the information included in the body of the message.";

        internal const string MsgConnectorType = "Whenever a message is passed by a connector application, the connector type is required so that the sending and receiving applications know how to interpret the security and acknowledgment properties of the messages. When sending application-encrypted messages, this property tells the MSMQ runtime to use the symmetric key.";

        internal const string MsgCorrelationId = "Provides an application-defined identifier that the receiving application can use to sort messages.";

        internal const string MsgDefaultBodySize = "The default body buffer size to create, when the message is received.";

        internal const string MsgDefaultExtensionSize = "The default extension buffer size to create, when the message is received.";

        internal const string MsgDefaultLabelSize = "The default label buffer size to create, when the message is received.";

        internal const string MsgDestinationQueue = "Identifies the original destination queue of a message.";

        internal const string MsgDestinationSymmetricKey = "Specifies the symmetric key used to encrypt messages. Is required when you send application-encrypted messages.";

        internal const string MsgDigitalSignature = "Specifies the digital signature used to authenticate the message.";

        internal const string MsgEncryptionAlgorithm = "Specifies the encryption algorithm used to encrypt the message body of a private message.";

        internal const string MsgExtension = "Provides a place to put additional application-defined information that is associated with the message.";

        internal const string MsgHashAlgorithm = "Identifies the hashing algorithm MSMQ uses when authenticating messages.";

        internal const string MsgId = "Indicates the MSMQ-generated identifier of the message.";

        internal const string MsgIsFirstInTransaction = "It is used by receiving applications to verify that a message was the first message sent in a single transaction to a single queue.";

        internal const string MsgIsLastInTransaction = "It is used by receiving applications to verify that a message was the last message sent from a single transaction to a single queue.";

        internal const string MsgLabel = "Specifies the label of the message.";

        internal const string MsgLookupId = "Indicates the MSMQ-generated lookup identifier of the message.";

        internal const string MsgMessageType = "A message can be a normal MSMQ message, a positive or negative (arrival and read) acknowledgment message, or a report message.";

        internal const string MsgPriority = "Message priority affects how MSMQ handles the message while it is in route, as well as where the message is placed in the queue.";

        internal const string MsgRecoverable = "The message will be delivered, even if a computer crashes while the message is en-route to the queue.";

        internal const string MsgResponseQueue = "Specifies the queue to which application-generated response messages are returned.";

        internal const string MsgSenderCertificate = "Specifies the security certificate used to authenticate messages.";

        internal const string MsgSenderId = "This property is set by MSMQ, and is used primarily by the receiving Queue Manager when authenticating a message.";

        internal const string MsgSenderVersion = "Specifies the version of MSMQ used to send the message.";

        internal const string MsgSentTime = "Indicates the date and time that the message was sent by the source Queue Manager.";

        internal const string MsgSourceMachine = "Specifies the computer where the message originated.";

        internal const string MsgTimeToBeReceived = "Specifies the total time (in seconds) the message is allowed to live. Use \"Infinity\" to set the maximum value.";

        internal const string MsgTimeToReachQueue = "Specifies a time limit (in seconds) for the message to reach the queue. Use \"Infinity\" to set the maximum value.";

        internal const string MsgTransactionId = "It is used by receiving applications to verify that a message was sent from a specific transaction.";

        internal const string MsgTransactionStatusQueue = "Identifies the transaction status queue on the source computer.";

        internal const string MsgUseAuthentication = "Specifies if the message needs to be authenticated.";

        internal const string MsgUseDeadLetterQueue = "Specifies if a copy of the message should be sent to a dead-letter queue.";

        internal const string MsgUseEncryption = "Set this property to have MSMQ encrypt a private message.";

        internal const string MsgUseJournalQueue = "Specifies if a copy of the message should be kept in a machine journal (on the originating machine).";

        internal const string MsgUseTracing = "Specifies if report messages are sent when tracing a message.";

        internal const string MsgTopObjectFormat = "Determines how the top (root) object of a graph is laid out in the serialized stream.";

        internal const string MsgTypeFormat = "Determines how type descriptions are laid out in the serialized stream.";

        internal const string MsgBodyStream = "Represents the information included in the body of the message.";

        internal const string MsgBodyType = "Indicates the type of body the message contains";

        internal const string XmlMsgTargetTypeNames = "Specifies the set of possible types that will be deserialized by the formatter from the message provided.";

        internal const string XmlMsgTargetTypes = "Specifies the set of possible types that will be deserialized by the formatter from the message provided.";

        internal const string MessageQueueDesc = "Provides access to a queue on a Message Queue server.";

        internal const string MQ_Authenticate = "Specifies whether or not the queue only accepts authenticated messages.";

        internal const string MQ_BasePriority = "Used for routing the queue's messages over the network.";

        internal const string MQ_CanRead = "Indicates if the queue has read permission.";

        internal const string MQ_CanWrite = "Indicates if the queue has write permission.";

        internal const string MQ_Category = "Allows applications to categorize their queues according to how they are used.";

        internal const string MQ_CreateTime = "Indicates the time and date when the queue was created.";

        internal const string MQ_DefaultPropertiesToSend = "Specifies the properties that are going to be used by default when sending messages to the queue referenced by this object.";

        internal const string MQ_DenySharedReceive = "If true, no other instance of this object will be able to receive messages.";

        internal const string MQ_EncryptionRequired = "Specifies whether or not the queue only accepts non-private (clear) messages.";

        internal const string MQ_FormatName = "Specifies a unique name for the queue generated by MSMQ when it is created.";

        internal const string MQ_Formatter = "This is the formatter that will be used when an object is written to or read from the body.";

        internal const string MQ_GuidId = "Identifies a specific public queue.";

        internal const string MQ_Label = "Specifies a description of the queue.";

        internal const string MQ_LastModifyTime = "Indicates the last time the properties of a queue were modified.";

        internal const string MQ_MachineName = "Specifies the machine where the queue referenced by this object is located.";

        internal const string MQ_MaximumJournalSize = "Specifies the maximum size (in kilobytes) of the journal queue. Use \"Infinity\" to set the maximum value.";

        internal const string MQ_MaximumQueueSize = "Specifies the maximum size (in kilobytes) of the queue. Use \"Infinity\" to set the maximum value.";

        internal const string MQ_MessageReadPropertyFilter = "Specifies the property filter used by this queue to receive messages.";

        internal const string MQ_MulticastAddress = "Specifies the IP multicast address associated with the queue.";

        internal const string MQ_Path = "Specifies the location of the queue that will be referenced by this object.";

        internal const string MQ_QueueName = "Specifies the friendly name that identifies the queue referenced by this object.";

        internal const string MQ_ReadHandle = "The native handle used to receive messages from the message queue.";

        internal const string MQ_SynchronizingObject = "The object used to marshal the event handler calls issued as a result of a BeginReceive or BeginPeek request.";

        internal const string MQ_Transactional = "If a queue is transactional, it can only accept messages that are sent as part of a transaction.";

        internal const string MQ_UseJournalQueue = "Specifies if messages retrieved from the MsgAuthenticationProviderNamequeue are also copied to its journal queue.";

        internal const string MQ_WriteHandle = "The native handle used to send messages to the message queue.";

        internal const string MQ_PeekCompleted = "This event occurs when a message is read without being removed from the queue using the BeginPeek method.";

        internal const string MQ_ReceiveCompleted = "This event occurs when a message is removed from the queue using the BeginReceive method.";

        internal static string GetString(string identifier, params object[] arguments)
        {
            switch (identifier)
            {
                case "MSMQNotInstalled":
                    return "Message Queuing has not been installed on this computer.";
                case "TooManyColumns":
                    return string.Format("Column Count limit exceeded ({0}).", arguments);
                case "PlatformNotSupported":
                    return "Requested operation is not supported on this platform.";
                case "MSMQInfoNotSupported":
                    return "Browsing private queues is not supported by the Microsoft Message Queuing (MSMQ) runtime installed on this computer.";
                case "InfiniteValue":
                    return "Infinity";
                case "InvalidTrustee":
                    return "Trustee property of an entry in the access control list is null.";
                case "InvalidTrusteeName":
                    return "Entry in the access control list contains a trustee with an invalid name.";
                case "CouldntResolve":
                    return "Could not resolve name {0} (error = {1} ).";
                case "CouldntResolveName":
                    return "Could not resolve name {0}.";
                case "DefaultSizeError":
                    return "Size is invalid. It must be greater than or equal to zero.";
                case "PathSyntax":
                    return "Path syntax is invalid.";
                case "InvalidParameter":
                    return "Invalid value {1} for parameter {0}.";
                case "InvalidXmlFormat":
                    return "XML format is invalid.";
                case "CriteriaNotDefined":
                    return "Criteria property has not been defined.";
                case "InvalidDateValue":
                    return "Date is invalid. It must be between {0} and {1}.";
                case "InvalidProperty":
                    return "Invalid value {1} for property {0}.";
                case "NoCurrentMessageQueue":
                    return "Cursor is not currently pointing to a MessageQueue instance. It is located either before the first or after the last queue in the enumeration.";
                case "LongQueueName":
                    return "Queue name is too long. Size of queue name cannot exceed 255 characters.";
                case "TransactionNotStarted":
                    return "Cannot commit or roll back transaction because BeginTransaction has not been called.";
                case "TransactionStarted":
                    return "Cannot start a transaction while a pending transaction exists.";
                case "StoredObjectsNotSupported":
                    return "Stored object format is not supported by ActiveXMessageFormatter.";
                case "InvalidTypeDeserialization":
                    return "Cannot deserialize the message passed as an argument. Cannot recognize the serialization format.";
                case "InvalidTypeSerialization":
                    return "Cannot serialize the object because its type is not supported.";
                case "IncorrectNumberOfBytes":
                    return "Wrote an incorrect number of bytes.";
                case "NotImplemented":
                    return "Feature is not implemented.";
                case "NotAcknowledgement":
                    return "Cannot retrieve property because the message is not an acknowledgment message.";
                case "MissingProperty":
                    return "Property {0} was not retrieved when receiving the message. Ensure that the PropertyFilter is set correctly.";
                case "ArrivedTimeNotSet":
                    return "Arrived time is undefined for this message. This message was not created by a call to the Receive method.";
                case "AuthenticationNotSet":
                    return "Cannot determine authentication for this message. This message was not created by a call to the Receive method.";
                case "FormatterMissing":
                    return "Cannot find a formatter capable of reading this message.";
                case "DestinationQueueNotSet":
                    return "Destination queue is not defined for this message. The message was not created by a call to the Receive method.";
                case "IdNotSet":
                    return "Unique identifier for this message is not defined. The message was not created by a call to the Receive method.";
                case "LookupIdNotSet":
                    return "Lookup identifier is not defined for this message. The message was not created by a call to the Receive method, or lookup identifier was not added to the properties to retrieve.";
                case "MessageTypeNotSet":
                    return "Type is not defined for this message. The message was not created by a call to the Receive method.";
                case "SenderIdNotSet":
                    return "Sender identifier is not defined for this message. The message was not created by a call to the Receive method.";
                case "VersionNotSet":
                    return "Message Queuing version is not defined for this message. The message was not created by a call to the Receive method.";
                case "SentTimeNotSet":
                    return "Sent time is not defined for this message. The message was not created by a call to the Receive method.";
                case "SourceMachineNotSet":
                    return "Source computer is not defined for this message. The message was not created by a call to the Receive method.";
                case "InvalidId":
                    return "Identifier is not in the incorrect format.";
                case "TypeListMissing":
                    return "Target type array is missing. The target type array must be set in order to deserialize the XML-formatted message.";
                case "InvalidLabel":
                    return "Cannot find queue with label {0}.";
                case "AmbiguousLabel":
                    return "Label \"{0}\" references more than one queue. Set the path for the desired queue.";
                case "InvalidQueuePathToCreate":
                    return "Cannot create a queue with the path {0}.";
                case "AsyncResultInvalid":
                    return "IAsyncResult interface passed is not valid because it was not created as a result of an asynchronous request on this object.";
                case "QueueExistsError":
                    return "Cannot determine whether a queue with the specified format name exists.";
                case "NoCurrentMessage":
                    return "Cursor is not currently pointing to a Message instance. It is located either before the first or after the last message in the enumeration.";
                case "NotSet":
                    return "[Not Set]";
                case "MessageNotFound":
                    return "Message requested was not found in the queue specified.";
                case "UnknownError":
                    return "Error 0x{0} is unknown.";
                default:
                    return null;
            }
        }
    }
}
