﻿// This file is part of AlarmWorkflow.
// 
// AlarmWorkflow is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AlarmWorkflow is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AlarmWorkflow.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Text;
using AlarmWorkflow.BackendService.SettingsContracts;
using AlarmWorkflow.Shared;
using AlarmWorkflow.Shared.Core;
using AlarmWorkflow.Shared.Specialized;

namespace AlarmWorkflow.AlarmSource.Mail
{
    sealed class MailConfiguration : DisposableObject
    {
        #region Fields

        private ISettingsServiceInternal _settings;

        #endregion

        #region Properties

        //internal string AttachmentPath => _settings.GetSetting("MailAlarmSource", "AttachmentPath").GetValue<string>();

        internal string ServerName => _settings.GetSetting("MailAlarmSource", "ServerName").GetValue<string>();

        internal int Port => _settings.GetSetting("MailAlarmSource", "Port").GetValue<int>();

        internal string UserName => _settings.GetSetting("MailAlarmSource", "UserName").GetValue<string>();

        internal string Password => _settings.GetSetting("MailAlarmSource", "Password").GetValue<string>();

        internal bool SSL => _settings.GetSetting("MailAlarmSource", "SSL").GetValue<bool>();

        internal string MailSubject => _settings.GetSetting("MailAlarmSource", "MailSubject").GetValue<string>();

        internal string MailSender => _settings.GetSetting("MailAlarmSource", "MailSender").GetValue<string>();

        internal bool AnalyzeAttachment => _settings.GetSetting("MailAlarmSource", "AnalyseAttachment").GetValue<bool>();

        internal string AttachmentName => _settings.GetSetting("MailAlarmSource", "AttachmentName").GetValue<string>();

        internal ReplaceDictionary ReplaceDictionary => _settings.GetSetting(SettingKeys.ReplaceDictionary).GetValue<ReplaceDictionary>();

        internal string ParserAlias => _settings.GetSetting("MailAlarmSource", "MailParser").GetValue<string>();

        internal Encoding Encoding => GetEncodingFromSettings();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MailConfiguration"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider to get the services from.</param>
        public MailConfiguration(IServiceProvider serviceProvider)
        {
            _settings = serviceProvider.GetService<ISettingsServiceInternal>();
        }

        #endregion

        #region Methods

        private Encoding GetEncodingFromSettings()
        {
            try
            {
                int codepage = _settings.GetSetting("MailAlarmSource", "CodePage").GetValue<int>();
                if (codepage != 0)
                {
                    return Encoding.GetEncoding(codepage);
                }
            }
            catch (Exception)
            {
            }

            return null;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        protected override void DisposeCore()
        {
            _settings = null;
        }

        #endregion
    }
}