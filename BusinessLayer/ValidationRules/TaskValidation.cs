using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TaskValidation : AbstractValidator<TaskTable>
    {
        public TaskValidation()
        {
            RuleFor(x=>x.title).NotEmpty().WithMessage("Title  cant be empty")
                                            .MinimumLength(3).WithMessage("Title must be greater than 3")
                                            .MaximumLength(30).WithMessage("Title must be less than 30");
        }
    }
}
