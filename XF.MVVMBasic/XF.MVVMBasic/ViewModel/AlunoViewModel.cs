using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XF.MVVMBasic.Model;

namespace XF.MVVMBasic.ViewModel
{
    public class AlunoViewModel
    {
        #region Propriedades
        public Aluno AlunoModel { get; set; }
        public ObservableCollection<Aluno> Alunos { get; set; } = new ObservableCollection<Aluno>();
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion
        public AlunoViewModel(ObservableCollection<Aluno> alunos)
        {
            this.Alunos = alunos;
        }
        public static ObservableCollection<Aluno> GetAluno()
        {
            ObservableCollection<Aluno> listaAlunos = new ObservableCollection<Aluno>();
            var aluno = new Model.Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "542621",
                Nome = "Anderson Silva",
                Email = "anderson@ufc.com"
            };
            var aluno2 = new Model.Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "40918",
                Nome = "Rafael Soares",
                Email = "rafael@fiap.com"
            };
            listaAlunos.Add(aluno);
            listaAlunos.Add(aluno2);
            
            return listaAlunos;
        }
    }

}

