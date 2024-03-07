using System;
using System.Diagnostics;

namespace Dovahkiin.Memory.mem
{
    /// <summary>
    /// Information about the opened process.
    /// </summary>
    public class Proc
    {
#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public Process Process { get; set; }
#pragma warning restore CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public IntPtr Handle { get; set; }
        public bool Is64Bit { get; set; }
        //public ConcurrentDictionary<string, IntPtr> Modules { get; set; } // Use mProc.Process.Modules instead
#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public ProcessModule MainModule { get; set; }
#pragma warning restore CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
    }
}
