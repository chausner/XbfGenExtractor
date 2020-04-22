﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GenXbfExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            // numTypes: to be found in Parser::IsStableXbfType
            // numProperties: to be found in Parser::IsStableXbfProperty
            // c_a*: table offsets can be found from debug symbols
            // enumValueTableStart/End: first and last case of switch control structure in GetEnumValueTable
            // enumValueTableJumpTableOffset: offset of jump table of switch control structure in GetEnumValueTable
            // oldPropertyFormat: only needed for older versions of GenXbf.dll

            Extract(
                genXbfPath: @"C:\Program Files (x86)\Windows Kits\10\bin\x86\GenXBF.dll",
                baseAddress: 0x10000C00,
                numTypes: 0x37E,
                numProperties: 0x63C,                
                c_aKnownTypeToStableXbfTypeOffset: 0x448A8,
                c_aKnownPropertyToStableXbfPropertyOffset: 0x43C30,
                c_aTypeNameInfosOffset: 0x3A6B8,
                c_aPropertyNamesOffset: 0x2C918,
                c_aPropertiesOffset: 0x340D0,
                enumValueTableStart: 0x2EA,
                enumValueTableEnd: 0x37D,
                enumValueTableJumpTableOffset: 0x56861,
                oldPropertyFormat: true,
                typeNames: out var typeNames,
                propertyNames: out var propertyNames,
                enumValues: out var enumValues);

            Extract(
                genXbfPath: @"C:\Program Files (x86)\Windows Kits\10\bin\10.0.14393.0\x86\genxbf.dll",
                baseAddress: 0x10000C00,
                numTypes: 0x39F,
                numProperties: 0x694,
                c_aKnownTypeToStableXbfTypeOffset: 0x48638,
                c_aKnownPropertyToStableXbfPropertyOffset: 0x49408,
                c_aTypeNameInfosOffset: 0x8FD8,
                c_aPropertyNamesOffset: 0x5910,
                c_aPropertiesOffset: 0x37E40,
                enumValueTableStart: 0x2FF,
                enumValueTableEnd: 0x39E,
                enumValueTableJumpTableOffset: 0x60224,
                oldPropertyFormat: true,
                typeNames: out var typeNames2,
                propertyNames: out var propertyNames2,
                enumValues: out var enumValues2);

            Extract(
                genXbfPath: @"C:\Program Files (x86)\Windows Kits\10\bin\10.0.15063.0\x86\genxbf.dll",
                baseAddress: 0x10000C00,
                numTypes: 0x3C2,
                numProperties: 0x6C3,
                c_aKnownTypeToStableXbfTypeOffset: 0x4B120,
                c_aKnownPropertyToStableXbfPropertyOffset: 0x4BF90,
                c_aTypeNameInfosOffset: 0x5E68,
                c_aPropertyNamesOffset: 0x2628,
                c_aPropertiesOffset: 0x13058,
                enumValueTableStart: 0x315,
                enumValueTableEnd: 0x3C1,
                enumValueTableJumpTableOffset: 0x6213A,
                oldPropertyFormat: true,
                typeNames: out var typeNames3,
                propertyNames: out var propertyNames3,
                enumValues: out var enumValues3);

            Extract(
                genXbfPath: @"C:\Program Files (x86)\Windows Kits\10\bin\10.0.16299.0\x86\genxbf.dll",
                baseAddress: 0x10000C00,
                numTypes: 0x3D9,
                numProperties: 0x6EB,                
                c_aKnownTypeToStableXbfTypeOffset: 0x4BEA0,
                c_aKnownPropertyToStableXbfPropertyOffset: 0x4A108,
                c_aTypeNameInfosOffset: 0x90F8,
                c_aPropertyNamesOffset: 0x5778,
                c_aPropertiesOffset: 0x33300,
                enumValueTableStart: 0x327,
                enumValueTableEnd: 0x3D8,
                enumValueTableJumpTableOffset: 0x628C6,
                oldPropertyFormat: true,
                typeNames: out var typeNames4,
                propertyNames: out var propertyNames4,
                enumValues: out var enumValues4);

            Extract(
                genXbfPath: @"C:\Program Files (x86)\Windows Kits\10\bin\10.0.17134.0\x86\genxbf.dll",
                baseAddress: 0x10000C00,
                numTypes: 0x409,
                numProperties: 0x762,
                c_aKnownTypeToStableXbfTypeOffset: 0x4C990,
                c_aKnownPropertyToStableXbfPropertyOffset: 0x4D908,
                c_aTypeNameInfosOffset: 0x96F0,
                c_aPropertyNamesOffset: 0x5998,
                c_aPropertiesOffset: 0x42210,
                enumValueTableStart: 0x351,
                enumValueTableEnd: 0x408,
                enumValueTableJumpTableOffset: 0x65715,
                oldPropertyFormat: false,
                typeNames: out var typeNames5,
                propertyNames: out var propertyNames5,
                enumValues: out var enumValues5);

            Extract(
                genXbfPath: @"C:\Program Files(x86)\Windows Kits\10\bin\10.0.17763.0\x86\genxbf.dll",
                baseAddress: 0x10000C00,
                numTypes: 0x42B,
                numProperties: 0x7E6,
                c_aKnownTypeToStableXbfTypeOffset: 0x4FC98,
                c_aKnownPropertyToStableXbfPropertyOffset: 0x51760,
                c_aTypeNameInfosOffset: 0x62F0,
                c_aPropertyNamesOffset: 0x2168,
                c_aPropertiesOffset: 0x160E0,
                enumValueTableStart: 0x36B,
                enumValueTableEnd: 0x42A,
                enumValueTableJumpTableOffset: 0x693A8,
                oldPropertyFormat: false,
                typeNames: out var typeNames6,
                propertyNames: out var propertyNames6,
                enumValues: out var enumValues6);

            Extract(
                genXbfPath: @"C:\Program Files(x86)\Windows Kits\10\bin\10.0.18362.1\x86\genxbf.dll",
                baseAddress: 0x10000C00,
                numTypes: 0x436,
                numProperties: 0x7FE,
                c_aKnownTypeToStableXbfTypeOffset: 0x55208,
                c_aKnownPropertyToStableXbfPropertyOffset: 0x53A68,
                c_aTypeNameInfosOffset: 0x5FE0,
                c_aPropertyNamesOffset: 0x1FE8,
                c_aPropertiesOffset: 0x16170,
                enumValueTableStart: 0x376,
                enumValueTableEnd: 0x435,
                enumValueTableJumpTableOffset: 0x6A621,
                oldPropertyFormat: false,
                typeNames: out var typeNames7,
                propertyNames: out var propertyNames7,
                enumValues: out var enumValues7);

            Merge(typeNames, typeNames2);
            Merge(propertyNames, propertyNames2);
            Merge(enumValues, enumValues2);

            Merge(typeNames, typeNames3);
            Merge(propertyNames, propertyNames3);
            Merge(enumValues, enumValues3);

            Merge(typeNames, typeNames4);
            Merge(propertyNames, propertyNames4);
            Merge(enumValues, enumValues4);

            Merge(typeNames, typeNames5);
            Merge(propertyNames, propertyNames5);
            Merge(enumValues, enumValues5);

            Merge(typeNames, typeNames6);
            Merge(propertyNames, propertyNames6);
            Merge(enumValues, enumValues6);

            Merge(typeNames, typeNames7);
            Merge(propertyNames, propertyNames7);
            Merge(enumValues, enumValues7);

            PrintTypeNames(typeNames, "TypeNames.cs");
            PrintPropertyNames(propertyNames, "PropertyNames.cs");
            PrintEnumValues(enumValues, "EnumValues.cs");
        }

        static void Extract(
            string genXbfPath,
            uint baseAddress,
            int numTypes,
            int numProperties,           
            int c_aKnownTypeToStableXbfTypeOffset,
            int c_aKnownPropertyToStableXbfPropertyOffset,
            int c_aTypeNameInfosOffset,
            int c_aPropertyNamesOffset,
            int c_aPropertiesOffset,
            int enumValueTableStart,
            int enumValueTableEnd,
            int enumValueTableJumpTableOffset,
            bool oldPropertyFormat,
            out Dictionary<ushort, TypeNameInfo> typeNames,
            out Dictionary<ushort, PropertyNameInfo> propertyNames,
            out Dictionary<ushort, EnumValueInfo> enumValues)
        {
            byte[] genXbfModule = File.ReadAllBytes(genXbfPath);

            int[] PrepareEnumValueTableData()
            {
                int[] data = new int[(enumValueTableEnd - enumValueTableStart + 1) * 3];

                for (int i = 0; i <= enumValueTableEnd - enumValueTableStart; i++)
                {                    
                    int jumpDestination = (int)(BitConverter.ToUInt32(genXbfModule, enumValueTableJumpTableOffset + i * 4) - baseAddress);
                    int numValues = (int)BitConverter.ToUInt32(genXbfModule, jumpDestination + 5);
                    int nameOffset = (int)(BitConverter.ToUInt32(genXbfModule, jumpDestination + 11) - baseAddress);

                    data[i * 3] = i + enumValueTableStart;
                    data[i * 3 + 1] = numValues;
                    data[i * 3 + 2] = nameOffset;
                }

                return data;
            }

            ushort[] c_aKnownTypeToStableXbfType = new ushort[numTypes];

            for (int i = 0; i < numTypes; i++)
                c_aKnownTypeToStableXbfType[i] = BitConverter.ToUInt16(genXbfModule, c_aKnownTypeToStableXbfTypeOffset + i * sizeof(ushort));

            ushort[] c_aKnownPropertyToStableXbfProperty = new ushort[numProperties];

            for (int i = 0; i < numProperties; i++)
                c_aKnownPropertyToStableXbfProperty[i] = BitConverter.ToUInt16(genXbfModule, c_aKnownPropertyToStableXbfPropertyOffset + i * sizeof(ushort));

            TypeNameInfo[] c_aTypeNameInfos = new TypeNameInfo[numTypes];

            for (int i = 0; i < numTypes; i++)
            {
                string typeName = ReadStringReference(c_aTypeNameInfosOffset + i * 20, genXbfModule, baseAddress);
                string fullTypeName = ReadStringReference(c_aTypeNameInfosOffset + i * 20 + 8, genXbfModule, baseAddress);

                if (typeName != null && fullTypeName != null)
                    c_aTypeNameInfos[i] = new TypeNameInfo() { Name = typeName, FullName = fullTypeName };
            }

            string[] c_aPropertyNames = new string[numProperties];

            for (int i = 0; i < numProperties; i++)
                c_aPropertyNames[i] = ReadStringReference(c_aPropertyNamesOffset + i * 8, genXbfModule, baseAddress);

            string[] c_aProperties = new string[numProperties];

            for (int i = 0; i < numProperties; i++)
            {
                ushort typeIndex = BitConverter.ToUInt16(genXbfModule, c_aPropertiesOffset + i * (oldPropertyFormat ? 16 : 12) + 2 * sizeof(ushort));

                c_aProperties[i] = c_aTypeNameInfos[typeIndex]?.FullName;
            }

            int[] stableXbfTypeToKnownType = InvertMapping(c_aKnownTypeToStableXbfType);
            int[] stableXbfPropertyToKnownProperty = InvertMapping(c_aKnownPropertyToStableXbfProperty);

            typeNames = new Dictionary<ushort, TypeNameInfo>();

            for (int i = 1; i < stableXbfTypeToKnownType.Length; i++)
            {
                int knownType = stableXbfTypeToKnownType[i];

                if (knownType != -1 && c_aTypeNameInfos[knownType] != null)
                    typeNames.Add((ushort)(0x8000 + i), c_aTypeNameInfos[knownType]);
            }

            propertyNames = new Dictionary<ushort, PropertyNameInfo>();

            for (int i = 1; i < stableXbfPropertyToKnownProperty.Length; i++)
            {
                int knownProperty = stableXbfPropertyToKnownProperty[i];

                if (knownProperty != -1 && c_aPropertyNames[knownProperty] != null && c_aProperties[knownProperty] != null)
                    propertyNames.Add((ushort)(0x8000 + i), 
                        new PropertyNameInfo() {
                            Name = c_aPropertyNames[knownProperty],
                            TypeFullName = c_aProperties[knownProperty] });
            }

            enumValues = new Dictionary<ushort, EnumValueInfo>();

            int[] getEnumValueTableData = PrepareEnumValueTableData();

            for (int i = 1; i < stableXbfTypeToKnownType.Length; i++)
            {
                int knownType = stableXbfTypeToKnownType[i];

                if (knownType == -1)
                    continue;

                Dictionary<int, string> values = null;

                for (int j = 0; j < getEnumValueTableData.Length; j += 3)
                {
                    if (getEnumValueTableData[j] == knownType)
                    {
                        if (values == null)
                            values = new Dictionary<int, string>();

                        int numValues = getEnumValueTableData[j + 1];
                        int offset = getEnumValueTableData[j + 2];

                        for (int k = 0; k < numValues; k++)
                        {
                            string valueName = ReadStringReference(offset + k * 12, genXbfModule, baseAddress);
                            int value = BitConverter.ToInt32(genXbfModule, offset + k * 12 + 8);
                            if (!values.ContainsKey(value))
                                values.Add(value, valueName);
                        }
                        break;
                    }
                }

                if (values == null)
                    continue;

                enumValues.Add((ushort)i, new EnumValueInfo()
                {
                    TypeFullName = c_aTypeNameInfos[knownType].FullName,
                    Values = values
                });
            }
        }

        static void PrintTypeNames(Dictionary<ushort, TypeNameInfo> typeNames, string path)
        {
            ushort maxKey = typeNames.Keys.Max();

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("string[] typeNames = {");

                for (ushort i = 0x8001; i <= maxKey; i++)
                {
                    if (typeNames.TryGetValue(i, out TypeNameInfo typeNameInfo))
                        streamWriter.WriteLine("    /* 0x{0} */ \"{1}\", // {2}", i.ToString("X4"), typeNameInfo.Name, typeNameInfo.FullName);
                    else
                        streamWriter.WriteLine("    /* 0x{0} */ null,", i.ToString("X4"));
                }

                streamWriter.WriteLine("};");
            }
        }

        static void PrintPropertyNames(Dictionary<ushort, PropertyNameInfo> propertyNames, string path)
        {
            ushort maxKey = propertyNames.Keys.Max();

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("string[] propertyNames = {");

                for (ushort i = 0x8001; i <= maxKey; i++)
                {
                    if (propertyNames.TryGetValue(i, out PropertyNameInfo propertyNameInfo))
                        streamWriter.WriteLine("    /* 0x{0} */ \"{1}\", // {2}", i.ToString("X4"), propertyNameInfo.Name, propertyNameInfo.TypeFullName);
                    else
                        streamWriter.WriteLine("    /* 0x{0} */ null,", i.ToString("X4"));
                }

                streamWriter.WriteLine("};");
            }
        }

        static void PrintEnumValues(Dictionary<ushort, EnumValueInfo> enumValues, string path)
        {
            ushort minKey = enumValues.Keys.Min();
            ushort maxKey = enumValues.Keys.Max();

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("Dictionary<int, string>[] enumValues = new Dictionary<int, string>[] {");

                for (ushort enumID = minKey; enumID <= maxKey; enumID++)
                {
                    if (enumValues.TryGetValue(enumID, out EnumValueInfo enumValueInfo))
                    {
                        streamWriter.Write("    /* 0x{0} */ new Dictionary<int, string> {{ ", enumID.ToString("X4"));
                        streamWriter.Write(string.Join(", ", enumValueInfo.Values.OrderBy(kvp2 => kvp2.Key).Select(kvp2 => string.Format("{{ {0}, \"{1}\" }}", kvp2.Key, kvp2.Value))));
                        streamWriter.WriteLine(" }, // " + enumValueInfo.TypeFullName);
                    }
                    else
                        streamWriter.WriteLine("    /* 0x{0} */ null,", enumID.ToString("X4"));
                }

                streamWriter.WriteLine("};");
            }
        }

        static int[] InvertMapping(ushort[] mapping)
        {
            int max = mapping.Max();

            int[] inversion = new int[max + 1];

            for (int i = 0; i < inversion.Length; i++)
                inversion[i] = -1;

            for (int i = 0; i < mapping.Length; i++)
            {
                if (mapping[i] == 0)
                    continue;

                if (inversion[mapping[i]] != -1)
                    throw new Exception("Invalid mapping");

                inversion[mapping[i]] = i;
            }

            return inversion;
        }

        static string ReadStringReference(int offset, byte[] genXbfModule, uint baseAddress)
        {
            int stringOffset = (int)(BitConverter.ToUInt32(genXbfModule, offset) - baseAddress);
            int stringLength = BitConverter.ToInt32(genXbfModule, offset + sizeof(uint));

            if (stringOffset < 0 || stringOffset >= genXbfModule.Length)
                return null;

            return Encoding.Unicode.GetString(genXbfModule, stringOffset, stringLength * 2);
        }

        static void Merge<TKey, TValue>(Dictionary<TKey, TValue> dictionary1, Dictionary<TKey, TValue> dictionary2) where TValue : IComparable<TValue>
        {
            foreach (TKey key in dictionary2.Keys)
            {
                TValue value2 = dictionary2[key];

                if (dictionary1.TryGetValue(key, out TValue value1))
                {
                    if (!value1.Equals(value2))
                    {
                        int comp = value1.CompareTo(value2);
                        if (comp < 0)
                        {
                            dictionary1.Remove(key);
                            dictionary1.Add(key, value2);
                        }
                        else if (comp > 0)
                        {
                        }
                        else
                            throw new Exception("Merge conflict");
                    }                       
                }
                else
                {
                    dictionary1.Add(key, value2);
                }
            }
        }
    }

    class TypeNameInfo : IComparable<TypeNameInfo>
    {
        public string Name;
        public string FullName;

        public override bool Equals(object obj)
        {
            if (!(obj is TypeNameInfo other))
                return false;

            return other.Name == Name && other.FullName == FullName;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ FullName.GetHashCode();
        }

        public int CompareTo(TypeNameInfo other)
        {
            return 0;
        }
    }

    class PropertyNameInfo : IComparable<PropertyNameInfo>
    {
        public string Name;
        public string TypeFullName;

        public override bool Equals(object obj)
        {
            if (!(obj is PropertyNameInfo other))
                return false;

            return other.Name == Name && other.TypeFullName == TypeFullName;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ TypeFullName.GetHashCode();
        }

        public int CompareTo(PropertyNameInfo other)
        {
            return 0;
        }
    }

    class EnumValueInfo : IComparable<EnumValueInfo>
    {
        public string TypeFullName;
        public Dictionary<int, string> Values;

        public override bool Equals(object obj)
        {
            if (!(obj is EnumValueInfo other))
                return false;

            if (other.TypeFullName != TypeFullName)
                return false;

            if (other.Values.Keys.Count != Values.Keys.Count)
                return false;

            foreach (int key in Values.Keys)
                if (other.Values[key] != Values[key])
                    return false;

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = TypeFullName.GetHashCode();

            foreach (string s in Values.Values)
                hashCode ^= s.GetHashCode();

            return hashCode;
        }

        public int CompareTo(EnumValueInfo other)
        {
            if (other.TypeFullName != TypeFullName)
                return 0;

            if (other.Equals(this))
                return 0;

            if (other.Values.Count == Values.Count)
                return 0;
            else if (other.Values.Count > Values.Count)
                return -other.CompareTo(this);
            
            foreach (var kvp in other.Values)
                if (!Values.ContainsKey(kvp.Key) || Values[kvp.Key] != kvp.Value)
                    return 0;

            return 1;
        }
    }
}
