﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Spellchecker", "CRRSP09:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~F:Deepgram.Abstractions.AbstractRestClient._deepgramClientOptions")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~F:Deepgram.Common.AudioEncoding.OggSpeex")]
[assembly: SuppressMessage("Spellchecker", "CRRSP09:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~F:Deepgram.LiveClient._deepgramClientOptions")]
[assembly: SuppressMessage("Spellchecker", "CRRSP09:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~M:Deepgram.Extensions.HttpClientExtensions.ConfigureDeepgram(System.Net.Http.HttpClient,Deepgram.Models.DeepgramClientOptions)~System.Net.Http.HttpClient")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~M:Deepgram.Extensions.ServiceCollectionExtensions.AddDeepgram(Microsoft.Extensions.DependencyInjection.IServiceCollection,Deepgram.Models.DeepgramClientOptions)~Microsoft.Extensions.DependencyInjection.IServiceCollection")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~M:Deepgram.Extensions.ServiceCollectionExtensions.AddDeepgram(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.String)~Microsoft.Extensions.DependencyInjection.IServiceCollection")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~M:Deepgram.Models.DeepgramClientOptions.#ctor(System.String)")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "namespace", Target = "~N:Deepgram")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "namespace", Target = "~N:Deepgram.DeepgramEventArgs")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "namespace", Target = "~N:Deepgram.Records.OnPrem")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~P:Deepgram.Models.GetProjectsUsageSummarySchema.Diarize")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~P:Deepgram.Models.TranscriptionSchema.Diarize")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "member", Target = "~P:Deepgram.Records.Config.Diarize")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Models.CreateOnPremCredentialsSchema")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Models.DeepgramClientOptions")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Models.PrerecordedSchema")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Models.PrerecordedSource")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.OnPremClient")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.PrerecordedClient")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Records.AsyncPrerecordedResponse")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Records.OnPrem.ListOnPremCredentialsResponse")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Records.OnPrem.OnPremCredentialResponse")]
[assembly: SuppressMessage("Spellchecker", "CRRSP08:A misspelled word has been found", Justification = "company name or internal naming not in standard spellcheck dictionary", Scope = "type", Target = "~T:Deepgram.Records.PreRecorded.SyncPrerecordedResponse")]

/* Unmerged change from project 'Deepgram (net8.0)'
Added:
[assembly: SuppressMessage("Performance", "SYSLIB1045:Convert to 'GeneratedRegexAttribute'.", Justification = "not used as not compatible with earlier frameworks that are supported by SDK", Scope = "member", Target = "~M:Deepgram.Extensions.HttpClientExtensions.SetBaseUrl(System.Net.Http.HttpClient,Deepgram.Models.DeepgramClientOptions)")]
[assembly: SuppressMessage("Performance", "SYSLIB1045:Convert to 'GeneratedRegexAttribute'.", Justification = "not used as not compatible with earlier frameworks that are supported by SDK", Scope = "member", Target = "~M:Deepgram.LiveClient.GetBaseUrl(Deepgram.Models.DeepgramClientOptions)~System.String")]
[assembly: SuppressMessage("Performance", "SYSLIB1045:Convert to 'GeneratedRegexAttribute'.", Justification = "not used as not compatible with earlier frameworks that are supported by SDK", Scope = "member", Target = "~M:Deepgram.Utilities.UserAgentUtil.GetInfo~System.String")]
*/
[assembly: SuppressMessage("GeneratedRegex", "SYSLIB1045:Convert to 'GeneratedRegexAttribute'.", Justification = "not used as not compatible with earlier frameworks that are supported by SDK", Scope = "member", Target = "~M:Deepgram.Extensions.HttpClientExtensions.SetBaseUrl(System.Net.Http.HttpClient,Deepgram.Models.DeepgramClientOptions)")]
[assembly: SuppressMessage("GeneratedRegex", "SYSLIB1045:Convert to 'GeneratedRegexAttribute'.", Justification = "not used as not compatible with earlier frameworks that are supported by SDK", Scope = "member", Target = "~M:Deepgram.LiveClient.GetBaseUrl(Deepgram.Models.DeepgramClientOptions)~System.String")]
[assembly: SuppressMessage("GeneratedRegex", "SYSLIB1045:Convert to 'GeneratedRegexAttribute'.", Justification = "not used as not compatible with earlier frameworks that are supported by SDK", Scope = "member", Target = "~M:Deepgram.Utilities.UserAgentUtil.GetInfo~System.String")]
[assembly: SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "Not suitable for the type", Scope = "member", Target = "~M:Deepgram.DeepgramEventArgs.ConnectionErrorEventArgs.#ctor(System.Exception)")]
