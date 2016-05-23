﻿using Mtc.Domain.Models;
using MtcModel;

namespace Mtc.Domain.Services.Interfaces
{
    public interface ISectionContentService : IBaseService<SectionContent>
    {
        void UpdateSectionContent(int sectionContentId, string title, string mainText);
    }
}