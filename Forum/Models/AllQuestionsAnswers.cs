using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class AllQuestionsAnswers
    {
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }
        
    }
}