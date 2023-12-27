using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models;

public class TasksModel
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe a descrição da tarefa")]
    [StringLength(100, ErrorMessage = "A descrição deve conter até 100 caracteres")]
    [MinLength(5, ErrorMessage = "A descrição deve conter no mínimo 5 caracteres")]
    [DisplayName("Descrição")]
    public string Description { get; set; } = string.Empty;

    [DisplayName("Concluída")]
    public bool Done { get; set; }

    [DisplayName("Criada em")]
    public DateTime StartDate { get; set; } = DateTime.Now;

    [DataType(DataType.DateTime)]
    [Required(ErrorMessage = "Informe a data de término")]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }

    [DisplayName("Usuário")]
    public string User { get; set; } = string.Empty;
}
