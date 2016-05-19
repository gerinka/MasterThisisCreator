﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mtc.Domain.Common;
using Mtc.Domain.Models;
using Mtc.Domain.Services;
using Mtc.Domain.Services.Interfaces;
using Mtc.WebClient.Models;

namespace Mtc.WebClient.Controllers
{
    public class ThesisController : Controller
    {
        private readonly IDocumentTemplateService _documentTemplateService;

        public ThesisController(IDocumentTemplateService documentTemplateService)
        {
            _documentTemplateService = documentTemplateService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PanelStructure()
        {
            var baseSearchCommand = new BaseSearchCommand<DocumentTemplate>();
            IEnumerable<DocumentTemplate> templates = _documentTemplateService.GetAll(baseSearchCommand).ToList();
            var documentGenerator = new DocumentGeneratorViewModel
            {
                AllTemplates = templates,
                Document = new Document(),
                User = new Person(),
                SelectedDocumentTemplate = new DocumentTemplate()
            };
            return View(documentGenerator);
        }
        public ActionResult TaskBoard()
        {
            return View();
        }
        public ActionResult TaskList()
        {
            return View();
        }

        public ActionResult WritingModule()
        {
            return View();
        }

        //
        // POST: /Thesis/CreateDocument
        [HttpPost]
        [AllowAnonymous]
        public ActionResult CreateDocument(DocumentGeneratorViewModel model)
        {
            var properTemplate = _documentTemplateService.GetById(model.SelectedDocumentTemplate.Id);
            model.Document.Template = properTemplate;
            return View();
        }
    }
}