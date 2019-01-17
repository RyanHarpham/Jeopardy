﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Question
    {
        private int Id { get; set; }
        private int CategoryID { get; set; }
        private string Type { get; set; }
        private List<Choice> Choices { get; set; }
        private string Answer { get; set; }
        private string State { get; set; }
        private int Weight { get; set; }
        private bool DailyDouble { get; set; }

        public Question CreateQuestion(int aID, int aCategoryID, string aType, List<Choice> aChoices, string aAnswer, string aState, int aWeight, bool aDailyDouble)
        {
            Question aQuestion = new Question();
            aQuestion.Id = aID;
            aQuestion.CategoryID = aCategoryID;
            aQuestion.Type = aType;
            aQuestion.Choices = aChoices;
            aQuestion.Answer = aAnswer;
            aQuestion.State = aState;
            aQuestion.Weight = aWeight;
            aQuestion.DailyDouble = aDailyDouble;
            return aQuestion;
        }

    }
}