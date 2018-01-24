﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionStore.Entity.Entities;
using FluentValidation;

namespace FashionStore_BLL.Validations.FaqValidations
{
    public class FaqAddValidator : AbstractValidator<FrequantlyQuestion>
    {
        public FaqAddValidator()
        {
            RuleFor(x => x.Question)
                .NotNull().WithMessage("Soru alanı boş geçilemez");
            RuleFor(x => x.Answer)
                .NotNull().WithMessage("Cevap alanı boş geçilemez.");
        }
    }
}
