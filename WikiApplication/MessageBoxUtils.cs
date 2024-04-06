using System.Media;

namespace WikiApplication;

public static class MessageBoxUtils
{
	public static DialogResult ShowFatalError(string message)
	{
		SystemSounds.Exclamation.Play();
		return MessageBox.Show(message, @"FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
	public static DialogResult ShowError(string message) =>
		MessageBox.Show(message, @"An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

	public static DialogResult ShowWarning(string message) =>
		MessageBox.Show(message, @"An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);

	public static DialogResult PromptYesNo(string message) =>
		MessageBox.Show(message, null, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
}