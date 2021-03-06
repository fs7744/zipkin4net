/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace zipkin4net.Tracers.Zipkin.Thrift
{

  /// <summary>
  /// Associates an event that explains latency with a timestamp.
  /// 
  /// Unlike log statements, annotations are often codes: for example "sr".
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Annotation : TBase
  {

    /// <summary>
    /// Microseconds from epoch.
    /// 
    /// This value should use the most precise value possible. For example,
    /// gettimeofday or multiplying currentTimeMillis by 1000.
    /// </summary>
    public long? Timestamp { get; set; }

    /// <summary>
    /// Usually a short tag indicating an event, like "sr" or "finagle.retry".
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// The host that recorded the value, primarily for query by service name.
    /// </summary>
    public Endpoint Host { get; set; }

    public Annotation() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I64) {
              Timestamp = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Value = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              Host = new Endpoint();
              Host.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Annotation");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Timestamp != null) {
        field.Name = "timestamp";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Timestamp.Value);
        oprot.WriteFieldEnd();
      }
      if (Value != null) {
        field.Name = "value";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Value);
        oprot.WriteFieldEnd();
      }
      if (Host != null) {
        field.Name = "host";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        Host.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override bool Equals(object that) {
      var other = that as Annotation;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Timestamp, other.Timestamp)
        && System.Object.Equals(Value, other.Value)
        && System.Object.Equals(Host, other.Host);
    }

    public override int GetHashCode() {
      int hashcode = 0;
      unchecked {
        hashcode = (hashcode * 397) ^ (Timestamp == null ? 0 : (Timestamp.GetHashCode()));
        hashcode = (hashcode * 397) ^ (Value == null ? 0 : (Value.GetHashCode()));
        hashcode = (hashcode * 397) ^ (Host == null ? 0 : (Host.GetHashCode()));
      }
      return hashcode;
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Annotation(");
      bool __first = true;
      if (Timestamp != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Timestamp: ");
        __sb.Append(Timestamp);
      }
      if (Value != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Value: ");
        __sb.Append(Value);
      }
      if (Host != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Host: ");
        __sb.Append(Host== null ? "<null>" : Host.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
