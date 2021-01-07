using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Huffman
{
    public static class HuffmanAlg
    {
        public static event Action ProgressEvent;
        private static BinaryReader SourceFile;

        private static void OnNotEnoughCodeEvent(ref string Code)
        {
            Code += HuffmanTree.ToBinaryString(SourceFile.ReadByte());
        }

        public static bool DecodeFile(string InputPath, string OutputPath)
        {
            bool OpenSuccessfully = true;
            BinaryWriter OutputFile = null;
            try
            {
                SourceFile = new BinaryReader(File.OpenRead(InputPath));
                OutputFile = new BinaryWriter(File.Create(OutputPath));
            }
            catch
            {
                OpenSuccessfully = false;
            }

            if (OpenSuccessfully)
            {
                HuffmanTree DecodingModel = new HuffmanTree();
                DecodingModel.CreateModel();
                DecodingModel.NotEnoughCodeEvent += new HuffmanTree.NotEnoughCodeEventDelegate(OnNotEnoughCodeEvent);
                bool FinishFlag = false;
                Byte? Symbol = 0;
                string Code = "";

                //убираем расширение
                do
                {
                }
                while (SourceFile.ReadChar() != '.');

                Code = HuffmanTree.ToBinaryString(SourceFile.ReadByte());

                while (!FinishFlag)
                {
                    Symbol = DecodingModel.Decode(ref Code);
                    if (Symbol == null) FinishFlag = true;
                    if (!FinishFlag)
                    {
                        OutputFile.Write((Byte)Symbol);
                    }
                }
            }
            SourceFile.Close();
            OutputFile.Close();
            return OpenSuccessfully;
        }

        public static string Encode_StrOut(string InputPath)
        {
            string str_out = "";
            bool OpenSuccessfully = true;
            try
            {
                SourceFile = new BinaryReader(File.OpenRead(InputPath));
            }
            catch
            {
                OpenSuccessfully = false;
            }

            if (OpenSuccessfully)
            {
                HuffmanTree EncodingModel = new HuffmanTree();
                EncodingModel.CreateModel();
                bool EndOfFile = false;
                Byte Symbol = 0;
                string Code;
                string Buffer = "";


                char[] CharTypeBuffer;
                FileInfo Finfo = new FileInfo(InputPath);

                while (!EndOfFile)
                {

                    try
                    {
                        Symbol = SourceFile.ReadByte();
                    }
                    catch
                    {
                        EndOfFile = true;
                    }

                    if (!EndOfFile) Code = EncodingModel.Encode(Symbol);
                    else Code = EncodingModel.Encode(null);
                    Code = Buffer + Code;
                    Buffer = Code.Substring(Code.Length - (Code.Length % 8), (Code.Length) - (Code.Length - (Code.Length % 8)));
                    Code = Code.Remove(Code.Length - (Code.Length % 8), (Code.Length) - (Code.Length - (Code.Length % 8)));
                    while (Code != "")
                    {
                        str_out = str_out + Code.Substring(0, 8);
                        Code = Code.Remove(0, 8);
                    }

                    if (EndOfFile)
                    {
                        while (Buffer.Length != 8) Buffer += "0";
                        str_out = str_out + Buffer;
                    }

                }
                SourceFile.Close();
            }
            return str_out;
        }

        public static bool EncodeFile(string InputPath, string OutputPath)
        {
            bool OpenSuccessfully = true;
            BinaryWriter OutputFile = null;
            try
            {
                SourceFile = new BinaryReader(File.OpenRead(InputPath));
                OutputFile = new BinaryWriter(File.Create(OutputPath));
            }
            catch
            {
                OpenSuccessfully = false;
            }

            if (OpenSuccessfully)
            {
                HuffmanTree EncodingModel = new HuffmanTree();
                EncodingModel.CreateModel();
                bool EndOfFile = false;
                Byte Symbol = 0;
                string Code;
                string Buffer = "";


                char[] CharTypeBuffer;
                FileInfo Finfo = new FileInfo(InputPath);
                CharTypeBuffer = (Finfo.Extension.Substring(1, Finfo.Extension.Length - 1) + ".").ToCharArray();
                OutputFile.Write(CharTypeBuffer);

                while (!EndOfFile)
                {

                    try
                    {
                        Symbol = SourceFile.ReadByte();
                    }
                    catch
                    {
                        EndOfFile = true;
                    }

                    if (!EndOfFile) Code = EncodingModel.Encode(Symbol);
                    else Code = EncodingModel.Encode(null);
                    Code = Buffer + Code;
                    Buffer = Code.Substring(Code.Length - (Code.Length % 8), (Code.Length) - (Code.Length - (Code.Length % 8)));
                    Code = Code.Remove(Code.Length - (Code.Length % 8), (Code.Length) - (Code.Length - (Code.Length % 8)));
                    while (Code != "")
                    {
                        OutputFile.Write(HuffmanTree.ToByte(Code.Substring(0, 8)));
                        Code = Code.Remove(0, 8);
                    }

                    if (EndOfFile)
                    {
                        while (Buffer.Length != 8) Buffer += "0";
                        OutputFile.Write(HuffmanTree.ToByte(Buffer));
                    }

                }
                SourceFile.Close();
                OutputFile.Close();
            }
            return OpenSuccessfully;
        }
    }
}
