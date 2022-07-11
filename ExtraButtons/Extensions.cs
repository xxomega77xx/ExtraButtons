﻿using System.IO;

namespace ExtraButtons
{
    public static class Extensions
    {
        public static byte[] ReadFully(this Stream input)
        {
            using MemoryStream memoryStream = new MemoryStream();
            input.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
