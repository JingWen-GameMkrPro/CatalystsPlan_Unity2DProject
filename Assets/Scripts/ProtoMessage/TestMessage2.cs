// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: test_message2.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from test_message2.proto</summary>
public static partial class TestMessage2Reflection {

  #region Descriptor
  /// <summary>File descriptor for test_message2.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TestMessage2Reflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChN0ZXN0X21lc3NhZ2UyLnByb3RvIjYKDFRldHNNZXNzYWdlMhIKCgJpaRgB",
          "IAEoBRIKCgJmZhgCIAEoAhIOCgZzdHJzdHIYAyABKAliBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TetsMessage2), global::TetsMessage2.Parser, new[]{ "Ii", "Ff", "Strstr" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TetsMessage2 : pb::IMessage<TetsMessage2> {
  private static readonly pb::MessageParser<TetsMessage2> _parser = new pb::MessageParser<TetsMessage2>(() => new TetsMessage2());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TetsMessage2> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TestMessage2Reflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TetsMessage2() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TetsMessage2(TetsMessage2 other) : this() {
    ii_ = other.ii_;
    ff_ = other.ff_;
    strstr_ = other.strstr_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TetsMessage2 Clone() {
    return new TetsMessage2(this);
  }

  /// <summary>Field number for the "ii" field.</summary>
  public const int IiFieldNumber = 1;
  private int ii_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Ii {
    get { return ii_; }
    set {
      ii_ = value;
    }
  }

  /// <summary>Field number for the "ff" field.</summary>
  public const int FfFieldNumber = 2;
  private float ff_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Ff {
    get { return ff_; }
    set {
      ff_ = value;
    }
  }

  /// <summary>Field number for the "strstr" field.</summary>
  public const int StrstrFieldNumber = 3;
  private string strstr_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Strstr {
    get { return strstr_; }
    set {
      strstr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TetsMessage2);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TetsMessage2 other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Ii != other.Ii) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Ff, other.Ff)) return false;
    if (Strstr != other.Strstr) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Ii != 0) hash ^= Ii.GetHashCode();
    if (Ff != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Ff);
    if (Strstr.Length != 0) hash ^= Strstr.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Ii != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Ii);
    }
    if (Ff != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(Ff);
    }
    if (Strstr.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Strstr);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Ii != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ii);
    }
    if (Ff != 0F) {
      size += 1 + 4;
    }
    if (Strstr.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Strstr);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TetsMessage2 other) {
    if (other == null) {
      return;
    }
    if (other.Ii != 0) {
      Ii = other.Ii;
    }
    if (other.Ff != 0F) {
      Ff = other.Ff;
    }
    if (other.Strstr.Length != 0) {
      Strstr = other.Strstr;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Ii = input.ReadInt32();
          break;
        }
        case 21: {
          Ff = input.ReadFloat();
          break;
        }
        case 26: {
          Strstr = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
