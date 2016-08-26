using System.Linq;
using System.Windows.Forms;

namespace Apresentacao
{
   internal  class ValidacaoInterfaces
    {
       internal bool validarCampoCadastrar(Control.ControlCollection controles)
       {
           
            
           foreach (Control ctrl in controles)
           {            
                    // 1: Validar se os campos forem nulos 
                   if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox) || ctrl.GetType() == typeof(RadioButton) || ctrl.GetType() == typeof(ComboBox) || ctrl.GetType() == typeof(RichTextBox))
                   {
                       if (ctrl.Text == "" && ctrl.Name != "txtCadastrarRG" && ctrl.Name != "txtCadastrarEmail" && ctrl.Name != "mskCadastrarTelefoneResidencial" && ctrl.Name != "txtCadastrarCodigo" && ctrl.Name != "txtCadastrarUrlVideo" && ctrl.Name != "txtCadastrarUrlImagem" && ctrl.Name != "txtSelecionarFiltroAlunoCodNome") 

                       {    // 1.1: Campo nome
                           if (ctrl.Name == "txtCadastrarNomeCompleto")
                           {                             
                               MessageBox.Show("Campo obrigatório nulo: Nome Completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }// 1.2: Campo Descrição
                           else if (ctrl.Name == "txtCadastrarDescricao")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Descrição", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }// 1.3: Campo ricktext Descrição
                           else if (ctrl.Name == "rckCadastrarDescricao")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Descrição", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }// 1.4: Campo telefone celular
                           else if (ctrl.Name == "mskCadastrarTelefoneCelular")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Telefone Celular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }// 1.5: Campo cadastrar centímetro
                           else if (ctrl.Name == "txtCadastrarCentimetro")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Centímetro/cm", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }// 1.6: Campo tipo medida corporal
                           else if (ctrl.Name == "cbxCadastrarTipoMedida")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Tipo de medida corporal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }
                           else if (ctrl.Name == "txtCadastrarRepeticoes")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Repetições", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }
                           else if (ctrl.Name == "cbxCadastrarTreinamentoDescricao")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Treinamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }
                           else if (ctrl.Name == "cbxCadastrarExercicio")
                           {
                               MessageBox.Show("Campo obrigatório nulo: Exercício", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }
                           //1.7: validar os demais campos 
                           else
                           {
                               MessageBox.Show("Campo obrigatório nulo: " + ctrl.Name.Substring(12), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               ctrl.Focus();
                               return true;
                           }
                         
                       }
                   }
                      
                   
               //2: Validar tamanhos fixos de campos: CPF
                if (ctrl.Name == "mskCadastrarCPF" && ctrl.Text.Count() != 11)
                   {
                       MessageBox.Show("CPF inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       ctrl.Focus();   
                    return true;
                   }
               // 2.1: Validar tamanho CEP
                if (ctrl.Name == "txtCadastrarCEP" && ctrl.Text.Count() != 8)
                {
                    MessageBox.Show("CEP inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrl.Focus();
                    return true;
                }
          
               // 2.2: Validar tamanho Telefone celular
               if (ctrl.Name == "mskCadastrarTelefoneCelular" && ctrl.Text.Count() != 11)
               {
                   MessageBox.Show(" Número do telefone celular inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }

               // 2.3 validar telefone resídencial

               if (ctrl.Name == "mskCadastrarTelefoneResidencial" && ctrl.Text.Count() > 0 && ctrl.Text.Count() != 10)
               {
                   MessageBox.Show(" Número do telefone resídencial inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }

               //3: Validar campos que não permitem valores númericos. Campo Nome
                if (ctrl.Text.Where(c => char.IsNumber(c)).Count() > 0 && ctrl.Name == "txtCadastrarNome")
                   {
                       string Nome = ctrl.Name.Substring(12);          
                           MessageBox.Show("Campo não permite números: Nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           ctrl.Focus();
                           return true;
                   }
                    // 3.1 validar cidade
                else if (ctrl.Text.Where(c => char.IsNumber(c)).Count() > 0 && ctrl.Name == "txtCadastrarCidade")
                     {      MessageBox.Show("Campo não permite números: Cidade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           ctrl.Focus();
                            return true;
                     }
                    //3.2 validar Descrição
                else if (ctrl.Text.Where(c => char.IsNumber(c)).Count() > 0 && ctrl.Name == "txtCadastrarDescricao")
                {
                    MessageBox.Show("Campo não permite números: Descrição", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrl.Focus();
                    return true;
                }  
                    //3.3 validar status
                else if(ctrl.Text.Where(c => char.IsNumber(c)).Count() > 0 && ctrl.Name == "txtCadastrarStatus")
                {
                    MessageBox.Show("Campo não permite números: Status", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrl.Focus();
                    return true;
                }
                

               // 4: Validar campos que não permitem letras. 
               if(ctrl.Name == "txtCadastrarRG" && ctrl.Text.Where(c=> char.IsLetter(c)).Count() > 0)
               {
                   MessageBox.Show("Campo não permite letras: RG", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }
                
               else if (ctrl.Name == "txtCadastrarNumero" && ctrl.Text.Where(c => char.IsLetter(c)).Count() > 0)
               {
                   MessageBox.Show("Campo não permite letras: Numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }
                   
               else if (ctrl.Name == "txtCadastrarCEP" && ctrl.Text.Where(c => char.IsLetter(c)).Count() > 0)
               {
                   MessageBox.Show("Campo não permite letras: CEP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }
               else if (ctrl.Name == "txtCadastrarCentimetro" && ctrl.Text.Where(c => char.IsLetter(c)).Count() > 0)
               {
                   MessageBox.Show("Campo não permite letras: Centímetro/cm", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }
               else if (ctrl.Name == "txtCadastrarSeries" && ctrl.Text.Where(c => char.IsLetter(c)).Count() > 0)
               {
                   MessageBox.Show("Campo não permite letras: Series", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }
               else if (ctrl.Name == "txtCadastrarRepeticoes" && ctrl.Text.Where(c => char.IsLetter(c)).Count() > 0)
               {
                   MessageBox.Show("Campo não permite letras: Repetições", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ctrl.Focus();
                   return true;
               }



               }
           return false;
          
           }

       //validar a interface  de pesquisar
       internal bool ValidarCampoPesquisar(TextBox texto,  string campo)
       {
          
           if (texto.Text == "")
           {
               MessageBox.Show("Digite o código ou "  +campo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               texto.Focus();
               return true;
           } 
           else if (texto.Text.Where(c=> char.IsPunctuation(c)).Count() > 0)
           {
               MessageBox.Show("Digite somente o código ou " + campo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               texto.Clear();
               texto.Focus();
               return true;
           }
               
           else if (texto.Text.Where(c => char.IsNumber(c)).Count() > 0 && texto.Text.Where(c => char.IsLetter(c)).Count() > 0)
           {
               MessageBox.Show("Digete somente o código ou " + campo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               texto.Clear();
               texto.Focus();
               return true;
           }
           return false;
       }

       //validar os radioButton 
       internal bool ValidarRadioButton(RadioButton radioButton1, RadioButton radioButton2)
       {    
           // 1: validar campos Checked. Campo Sexo
           if ((radioButton1.Name == "rbtCadastrarSexoMasculino" && radioButton1.Checked == false ) && (radioButton2.Name == "rbtCadastrarSexoFeminino" && radioButton2.Checked == false) )
           {
               MessageBox.Show("Campo obrigatório não marcado: Sexo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return true;
           } //1.1 validar Ativo 
           else if ((radioButton1.Name == "rbtCadastrarAtivoSim" && radioButton1.Checked == false) && (radioButton2.Name == "rbtCadastrarAtivoNao" && radioButton2.Checked == false))
           {
               MessageBox.Show("Campo obrigatório não marcado: Ativo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return true;
           }

           return false;
       }

      
    }
}
