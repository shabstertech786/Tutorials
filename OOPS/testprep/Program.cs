using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprep
{
    using System;

    using System;

    using System.IO;
    using System.Text;

    public class Counter
    {
        private int count = 0;
        private int increment;

        public DocumentCounter(int increment)
        {
            this.increment = increment;
        }

        public int GetAndIncrement()
        {
            this.count += this.increment;
            return this.count;
        }
    }

    public class DocumentNameCreator
    {
        private string prefix;
        private Counter counter;

        public DocumentNameCreator(Counter counter, string prefix)
        {
            this.prefix = prefix;
            this.counter = counter;
        }

        public string GetNewDocumentName()
        {
            return prefix + this.counter.GetAndIncrement();
        }
    }

    public class DecoratorStream : Stream
    {
        private Stream stream;
        private string prefix;
        private byte[] prefixBytes;
        public override bool CanSeek { get { return false; } }
        public override bool CanWrite { get { return true; } }
        public override long Length { get; }
        public override long Position { get; set; }
        public override bool CanRead { get { return false; } }
        private UTF8Encoding uniEncoding = new UTF8Encoding();

        public DecoratorStream(Stream stream, string prefix) : base()
        {
            this.stream = stream;
            this.prefix = prefix;
            prefixBytes = uniEncoding.GetBytes(this.prefix);
        }

        public override void SetLength(long length)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] bytes, int offset, int count)
        {
            ////var newbytes = bytes.Append(this.prefixBytes);
            this.stream.Write(bytes, offset, count);
        }

        public override int Read(byte[] bytes, int offset, int count)
        {
            throw new NotSupportedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void Flush()
        {
            stream.Flush();
        }
    }

    public class Account
    {
        [Flags]
        public enum Access
        {
            Delete,
            Publish,
            Submit,
            Comment,
            Modify
        }
    }

    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var allElements = names1.Concat(names2).ToArray();
            return allElements.Distinct().ToArray();
        }
    }

    public class Crab
    {
        public virtual string PinchClaws()
        {
            return "clap clap";
        }
    }

    public class CoconutCrab : Crab
    {
        public override string PinchClaws()
        {
            return "CLAP CLAP";
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            ////byte[] message = new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x2c, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21 };
            ////using (MemoryStream stream = new MemoryStream())
            ////{
            ////    using (DecoratorStream decoratorStream = new DecoratorStream(stream, "First line: "))
            ////    {
            ////        decoratorStream.Write(message, 0, message.Length);

            ////        stream.Position = 0;
            ////        Console.WriteLine(new StreamReader(stream).ReadLine());  //should print "First line: Hello, world!"
            ////    }
            ////}
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
}