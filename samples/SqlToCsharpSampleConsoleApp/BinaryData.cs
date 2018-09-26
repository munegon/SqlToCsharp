﻿// Code generated by SqlToCsharp

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlToCsharpSample
{
    public partial class BinaryData
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Required]
        public byte[] Data { get; set; }
        public byte[] NullableData { get; set; }
        [Required]
        public byte[] VarData { get; set; }
        public byte[] NullableVarData { get; set; }
    }
}
