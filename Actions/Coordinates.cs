﻿// Decompiled with JetBrains decompiler
// Type: CloudinaryDotNet.Actions.Coordinates
// Assembly: CloudinaryDotNet, Version=1.0.30.0, Culture=neutral, PublicKeyToken=c8234dc617ae7841
// MVID: 85795B22-FB3A-4216-BE8E-309002E93AB1
// Assembly location: C:\Users\Joel.TRANCON\AppData\Local\Temp\Mudimuk\dbdb731dac\lib\net40\CloudinaryDotNet.dll

using System.Runtime.Serialization;

namespace CloudinaryDotNet.Actions
{
    [DataContract]
    public class Coordinates
    {
        [DataMember(Name = "custom")]
        public int[][] Custom { get; protected set; }

        [DataMember(Name = "faces")]
        public int[][] Faces { get; protected set; }
    }
}