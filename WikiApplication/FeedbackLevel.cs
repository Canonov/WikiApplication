﻿using System.Media;

namespace WikiApplication;

public enum FeedbackLevel
{
	Notice,
	Warning,
	Error,
}

public static class FeedbackLevelExtensions
{
	public static SystemSound? GetSound(this FeedbackLevel level) => level switch
	{
		FeedbackLevel.Notice => null,
		FeedbackLevel.Warning => SystemSounds.Exclamation,
		FeedbackLevel.Error => SystemSounds.Exclamation,
		_ => throw new ArgumentOutOfRangeException(nameof(level), level, null)
	};
}