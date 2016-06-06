﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Mtc.Infrastructure.DataAccess.Interfaces;
using MtcModel;

namespace Mtc.Infrastructure.DataAccess.Repositories
{
    public class StructureContentRepository : BaseRepository<STRUCTURECONTENT>, IStructureContentRepository
    {
        public StructureContentRepository(MtcEntities context) : base(context)
        {
        }

        public override void Update(STRUCTURECONTENT entityToUpdate)
        {
            base.Update(entityToUpdate);
        }
    }
}
