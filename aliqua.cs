// Initialize an empty list to store the filtered folders
var filteredFoldersWithFiles = new List<FolderType>();

// Iterate through each folder in the foldersWithFiles collection
foreach (var folder in foldersWithFiles)
{
    // Check if the current folder is not null
    if (folder != null)
    {
        // If the folder is not null, add it to the filtered list
        filteredFoldersWithFiles.Add(folder);
    }
}

// Convert the list to an array after filtering
var filteredFoldersArray = filteredFoldersWithFiles.ToArray();
