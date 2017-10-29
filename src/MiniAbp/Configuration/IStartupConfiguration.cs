﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniAbp.Dependency;
using MiniAbp.Domain.Uow;

namespace MiniAbp.Configuration
{
    public interface IStartupConfiguration : IDictionaryBasedConfig
    {
        /// <summary>
        /// Gets the IOC manager associated with this configuration.
        /// </summary>
        IocManager IocManager { get; }
        DatabaseConfiguration Database {get;}
        AuditConfiguration Auditing {get;}
        LocalizationConfiguration Localization { get;}
        CustomConfiguration Custom { get; }
        /// <summary>
        /// Used to configure unit of work defaults.
        /// </summary>
        IUnitOfWorkDefaultOptions UnitOfWork { get; }


        void Initialize();
        /// <summary>
        /// 使用Sql server 作为存储
        /// </summary>
        /// <param name="connectStringOrName"></param>
        void UseSqlServerStorage(string connectStringOrName);
    }
}
