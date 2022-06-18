using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverUsername).NotEmpty().WithMessage("Blog başlığı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Blog başlığı boş geçilemez");
            RuleFor(x => x.MessageDetails).NotEmpty().WithMessage("Blog başlığı boş geçilemez");



        }
    }
}
