using Avalonia;
using System;

namespace VisualProgramming_LAB8.Models
{
    public class ChangeStartPointEventArgs : EventArgs
    {
        public Point OldStartPoint { get; set; }
        public Point NewStartPoint { get; set; }
    }
}
