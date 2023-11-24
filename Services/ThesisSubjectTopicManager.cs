﻿using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ThesisSubjectTopicManager : IThesisSubjectTopicService
    {
        private readonly IRepositoryManager _manager;

        public ThesisSubjectTopicManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateThesisSubjectTopic(ThesisSubjectTopic thesisSubjectTopic)
        {
            _manager.ThesisSubjectTopic.CreateThesisSubjectTopic(thesisSubjectTopic);
            _manager.Save();
        }

        public IEnumerable<ThesisSubjectTopic> GetAllThesisSubjectTopics(bool trackChanges)
        {
            return _manager.ThesisSubjectTopic.FindAll(trackChanges);
        }

        public ThesisSubjectTopic? GetOneThesisSubjectTopic(int id, bool trackChanges)
        {
            return _manager.ThesisSubjectTopic.GetOneThesisSubjectTopic(id, trackChanges);
        }
    }
}
