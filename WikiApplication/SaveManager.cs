using System.Diagnostics;
using System.Text;

namespace WikiApplication;

/*
 * Updated on 2024/04/17
 * Programmer: 30048254
 * Name: SaveManager.cs
 * Handles saving and loading of the information class to and from a binary file format. (.DAT)
 * Copyright (c) 2024 - CITEMS
 */

public class SaveManager
{
    public readonly record struct Result(bool Success, string? Message = null, Exception? Exception = null);

    private readonly List<Information> wiki;

    private string filePath = Path.Combine(Application.StartupPath, DefaultFileName);
    private const string DefaultFileName = "definitions.dat";
    private const string FileTypeFilter = "data files (*.dat)|*.dat|All files (*.*)|*.*";

    public SaveManager(List<Information> wiki)
    {
        this.wiki = wiki;
    }

    public Result SaveFile(bool skipPrompt = false)
    {
        if (!skipPrompt)
        {
            var dialog = GetSaveFileDialog();
            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
                return new Result(false, "User cancelled the operation");

            filePath = dialog.FileName;
        }
        try
        {
            TrySaveToFile();
            return new Result(true);
        }
        catch (IOException ex)
        {
            Trace.WriteLine(ex);
            return new Result(false, $"IO Exception occurred: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            Trace.WriteLine(ex);
            return new Result(false, $"Unexpected error occurred: {ex.Message}", ex);
        }
    }

    public Result LoadFile()
    {
        var dialog = GetOpenFileDialog();
        var result = dialog.ShowDialog();

        if (result != DialogResult.OK)
            return new Result(false, "User cancelled the operation");

        filePath = dialog.FileName;

        try
        {
            TryLoadFromFile();
            return new Result(true);
        }
        catch (IOException ex)
        {
            Trace.WriteLine(ex);
            return new Result(false, $"IO Exception occurred: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            Trace.WriteLine(ex);
            return new Result(false, $"Unexpected error occurred: {ex.Message}", ex);
        }
    }

    private void TryLoadFromFile()
    {
        using var stream = File.Open(filePath, FileMode.Open);
        using var reader = new BinaryReader(stream, Encoding.UTF8, false);

        int size = reader.ReadInt32();
        wiki.Clear();

        for (int i = 0; i < size; i++)
        {
            string name = reader.ReadString();
            string category = reader.ReadString();
            string structure = reader.ReadString();
            string definition = reader.ReadString();

            wiki.Add(new Information(name, category, structure, definition));
        }
    }

    private void TrySaveToFile()
    {
        using var stream = File.Open(filePath, FileMode.Create);
        using var writer = new BinaryWriter(stream, Encoding.UTF8, false);

        writer.Write(wiki.Count);
        foreach (var info in wiki)
        {
            writer.Write(info.GetName());
            writer.Write(info.GetCategory());
            writer.Write(info.GetStructure());
            writer.Write(info.GetDefinition());
        }
    }

    #region File Dialogs

    private OpenFileDialog GetOpenFileDialog() => new OpenFileDialog
    {
        Filter = FileTypeFilter,
        InitialDirectory = Path.GetDirectoryName(filePath) ?? Application.StartupPath,
        FileName = Path.GetFileName(filePath) ?? DefaultFileName,
    };

    private SaveFileDialog GetSaveFileDialog() => new SaveFileDialog
    {
        Filter = FileTypeFilter,
        InitialDirectory = Path.GetDirectoryName(filePath) ?? Application.StartupPath,
        FileName = Path.GetFileName(filePath) ?? DefaultFileName,
        AddExtension = true,
        DefaultExt = "dat",
        CheckWriteAccess = true,
    };

    #endregion
}