﻿// Decompiled with JetBrains decompiler
// Type: CloudinaryDotNet.Actions.TransformResult
// Assembly: CloudinaryDotNet, Version=1.0.30.0, Culture=neutral, PublicKeyToken=c8234dc617ae7841
// MVID: 85795B22-FB3A-4216-BE8E-309002E93AB1
// Assembly location: C:\Users\Joel.TRANCON\AppData\Local\Temp\Mudimuk\dbdb731dac\lib\net40\CloudinaryDotNet.dll

using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CloudinaryDotNet.Actions
{
    [DataContract]
    public class TransformResult : BaseResult
    {
        [DataMember(Name = "message")]
        public string Message { get; protected set; }

        internal static Task<TransformResult> Parse(HttpResponseMessage response)
        {
            return Parse<TransformResult>(response);
        }
    }
}