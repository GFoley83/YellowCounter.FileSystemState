﻿using System.Collections.Generic;
using System.IO;

namespace YellowCounter.FileSystemState
{
    public class FileChangeList : List<FileChange>
    {
        internal void AddAdded(string directory, string path) => Add(new FileChange(directory, path, WatcherChangeTypes.Created));

        internal void AddChanged(string directory, string path) => Add(new FileChange(directory, path, WatcherChangeTypes.Changed));

        internal void AddRemoved(string directory, string path) => Add(new FileChange(directory, path, WatcherChangeTypes.Deleted));
    }
}
