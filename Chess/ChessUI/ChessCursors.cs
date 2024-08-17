using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChessUI
{
    public static class ChessCursors
    {

        public static readonly Cursor WhiteCursor = LoadCursor("Assets/CursorW.cur");
        public static readonly Cursor BlackCursor = LoadCursor("Assets/CursorB.cur");
        
        /// <summary>
        /// Loads a cursor from the specified file path.
        /// </summary>
        /// <param name="filePath">The relative or absolute path to the cursor file.</param>
        /// <returns>A new Cursor object representing the loaded cursor.</returns>
        /// <remarks>
        /// The function uses <see cref="Application.GetResourceStream"/> to open a stream to the specified file.
        /// The stream is then passed to the <see cref="Cursor"/> constructor, which creates a new Cursor object.
        /// The second parameter of the Cursor constructor is set to true, indicating that the cursor should be disposed of when no longer in use.
        /// </remarks>
        private static Cursor LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
