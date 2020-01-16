﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPG_Funcionarios.Models {
    public class SeedData {

        public static void Populate(IPGFuncionariosDbContext db) {

            PopulateProfesor(db);
            PopulateFuncionario(db);
            PopulateDepartamento(db);

            PopulateServico(db);
            PopulateEscola(db);
            PopulateTarefa(db);
            PopulateCargo(db);
            PopulateFerias(db);
        }

        private static void PopulateServico(IPGFuncionariosDbContext db)
        {
            if (db.Servico.Any())
            {
                return;
            }

            db.Servico.AddRange(
                new Servico { Nome = "Gabinete de Apoio à Presidência" },
                new Servico { Nome = "Divisão Financeira" },
                new Servico { Nome = "Divisão de Recursos Humanos" },
                new Servico { Nome = "Direcção dos Serviços Académicos" },
                new Servico { Nome = "Gabinete Jurídico" },
                new Servico { Nome = "Gabinete de Instalações, Manutenção e Equipamentos" },
                new Servico { Nome = "Centro de Informática" },
                new Servico { Nome = "Gabinete de Informação e Comunicação" },
                new Servico { Nome = "Gabinete de Formação, Cultura e Desporto" },
                new Servico { Nome = "Gabinete de Mobilidade e Cooperação" }
            );

            db.SaveChanges();
        }

        private static void PopulateEscola(IPGFuncionariosDbContext db)
        {
            if (db.Escola.Any())
            {
                return;
            }

            db.Escola.AddRange(
                new Escola { Nome = "ESECD", Descricao = "Escola Superior de Educação, Comunicação e Desporto", Localizacao = "Guarda" },
                new Escola { Nome = "ESTG", Descricao = "Escola Superior de Tecnologia e Gestão", Localizacao = "Guarda" },
                new Escola { Nome = "ESTH", Descricao = "Escola Superior de Turismo e Hotelaria", Localizacao = "Seia" },
                new Escola { Nome = "ESS", Descricao = "Escola Superior de Saúde", Localizacao = "Guarda" }
            );

            db.SaveChanges();
        }

        private static void PopulateTarefa(IPGFuncionariosDbContext db)
        {
            if (db.Tarefa.Any())
            {
                return;
            }

            db.Tarefa.AddRange(
                new Tarefa { Nome = "Tarefa A", Descricao = "Descrição A", Data = new DateTime(2019, 03, 04) },
                new Tarefa { Nome = "Tarefa B", Descricao = "Descrição B", Data = new DateTime(2020, 01, 07) },
                new Tarefa { Nome = "Tarefa C", Descricao = "Descrição C", Data = new DateTime(2016, 02, 20) },
                new Tarefa { Nome = "Tarefa D", Descricao = "Descrição D", Data = new DateTime(2019, 11, 17) }
            );

            db.SaveChanges();
        }

        private static void PopulateCargo(IPGFuncionariosDbContext db)
        {
            if (db.Cargo.Any())
            {
                return;
            }

            db.Cargo.AddRange(
                new Cargo { NomeCargo = "Presidente" },
                new Cargo { NomeCargo = "Vice-presidente" },
                new Cargo { NomeCargo = "Administrador" },
                new Cargo { NomeCargo = "Diretor de Serviços" },
                new Cargo { NomeCargo = "Chefe de Divisão" },
                new Cargo { NomeCargo = "Técnico superior área jurídica" },
                new Cargo { NomeCargo = "Técnico superior área de BAD " },
                new Cargo { NomeCargo = "Técnico superior" },
                new Cargo { NomeCargo = "Especialista de informática " },
                new Cargo { NomeCargo = "Técnico de informática " },
                new Cargo { NomeCargo = "Coordenador técnico " },
                new Cargo { NomeCargo = "Assistente Técnico " },
                new Cargo { NomeCargo = "Encarregado de pessoal auxiliar " },
                new Cargo { NomeCargo = "Assistente operacional " }
            );//REF: http://www.ipg.pt/website/files/PLANO%20ATIVIDADES%20IPG%202017_final.pdf

            db.SaveChanges();
        }

        private static void PopulateProfesor(IPGFuncionariosDbContext db)
        {
            if (db.Professor.Any()) {
                return;
            }

            db.Professor.AddRange(
                /* Dados dos professores do ESTG --> http://www.estg.ipg.pt/utc.aspx?id=5 */
                new Professor { Nome = "Noel de Jesus Lopes", Contacto = "234341216", Email = "noel@sal.ipg.pt", Gabinete = "27" },
                new Professor { Nome = "Paulo Jorge Nunes", Contacto = "243654732", Email = "pnunes@sal.ipg.pt", Gabinete = "21" },
                new Professor { Nome = "José Alberto Quitério Figueiredo", Contacto = "235446372", Email = "jfig@ipg.pt", Gabinete = "21" },
                new Professor { Nome = "António Mário Martins", Contacto = "235362735", Email = "amrmartins@ipg.pt", Gabinete = "47" },
                new Professor { Nome = "Beatriz de Jesus Rebelo", Contacto = "234257634", Email = "bjrebelo@ipg.pt", Gabinete = "4" },
                new Professor { Nome = "Carlos Carreto", Contacto = "253729564", Email = "ccarreto@ipg.pt", Gabinete = "17" },
                new Professor { Nome = "Carlos Jorge Gonçalves Brigas", Contacto = "936594630", Email = "brigas@ipg.pt", Gabinete = "33" },
                new Professor { Nome = "Celestino Gonçalves", Contacto = "946925405", Email = "celestin@ipg.pt", Gabinete = "42" },
                new Professor { Nome = "Fernando Rodrigues", Contacto = "225745473", Email = "fmr@ipg.pt", Gabinete = "61" },
                new Professor { Nome = "José Carlos Fonseca", Contacto = "925493548", Email = "josefonseca@ipg.pt", Gabinete = "62" },
                new Professor { Nome = "Maria Clara Silveira", Contacto = "246395630", Email = "mclara@ipg.pt", Gabinete = "63" },
                new Professor { Nome = "Natália Fernandes Gomes", Contacto = "935241743", Email = "ngomes@ipg.pt", Gabinete = "64" },

                /* Dados dos professores do ESTH --> http://www.esth.ipg.pt/utc.aspx?id=1 */
                new Professor { Nome = "Adriano Azevedo Costa", Contacto = "253465284", Email = "outro1@email.com", Gabinete = "65" },
                new Professor { Nome = "Elsa Maria Costa Ventura Ramos", Contacto = "245436650", Email = "outro2@email.com", Gabinete = "66" },
                new Professor { Nome = "Fernando Manuel Florim Ribeiro de Lemos", Contacto = "243654507", Email = "outro3@email.com", Gabinete = "67" },
                new Professor { Nome = "Gonçalo Poeta Fernandes", Contacto = "943676786", Email = "outro4@email.com", Gabinete = "68" },
                new Professor { Nome = "Manuel António Brites Salgado", Contacto = "950768556", Email = "outro5@email.com", Gabinete = "69" },

                /* Dados dos professores do ESS --> http://www.ess.ipg.pt/utc.aspx?id=1 */
                new Professor { Nome = "Abílio Madeira Figueiredo", Contacto = "950754365", Email = "outro6@email.com", Gabinete = "70" },
                new Professor { Nome = "Agostinha Esteves Melo Corte", Contacto = "246505436", Email = "outro7@email.com", Gabinete = "71" },
                new Professor { Nome = "Ana Maria Jorge", Contacto = "246507686", Email = "outro8@email.com", Gabinete = "72" },
                new Professor { Nome = "António Manuel Almeida Tavares Sequeira", Contacto = "254356507", Email = "outro9@email.com", Gabinete = "73" },
                new Professor { Nome = "António Manuel Martins Batista", Contacto = "246507654", Email = "outro10@email.com", Gabinete = "74" },
                new Professor { Nome = "Ermelinda Maria Bernardo Gonçalves Marques", Contacto = "236540768", Email = "outro11@email.com", Gabinete = "75" },
                new Professor { Nome = "Ezequiel Martins Carrondo", Contacto = "930768766", Email = "outro12@email.com", Gabinete = "76" },

                /* Dados dos professores do ESECD --> http://www.esecd.ipg.pt/utc.aspx?id=1 */
                new Professor { Nome = "Carla Helena Henriques C.T. Ravasco Nobre", Contacto = "245465076", Email = "outro13@email.com", Gabinete = "77" },
                new Professor { Nome = "Cristina Rita Ferreira Arala Chaves", Contacto = "246507436", Email = "outro14@email.com", Gabinete = "78" },
                new Professor { Nome = "Maria Helena Teixeira Pinto", Contacto = "207543654", Email = "outro15@email.com", Gabinete = "79" },
                new Professor { Nome = "Maria João Marques Alves da Costa", Contacto = "245076354", Email = "outro16@email.com", Gabinete = "80" },
                new Professor { Nome = "Mário José da Silva Meleiro", Contacto = "246432546", Email = "outro17@email.com", Gabinete = "81" },
                new Professor { Nome = "Rosa Branca Almeida Figueiredo", Contacto = "254076686", Email = "outro18@email.com", Gabinete = "82" },
                new Professor { Nome = "Rui Manuel Formoso Nobre dos Santos", Contacto = "246543686", Email = "outro19@email.com", Gabinete = "83" },

                /* Apenas Dados */
                new Professor { Nome = "Bill Gates", Contacto = "985279130", Email = "email100@gmail.com", Gabinete = "E100" },
                new Professor { Nome = "Will Smith", Contacto = "911998189", Email = "email101@gmail.com", Gabinete = "E101" },
                new Professor { Nome = "Neil deGrasse Tyson", Contacto = "915734639", Email = "email102@gmail.com", Gabinete = "E102" },
                new Professor { Nome = "Abel Garcia Abejas", Contacto = "965636170", Email = "email103@gmail.com", Gabinete = "E103" },
                new Professor { Nome = "Abel João Padrão Gomes", Contacto = "961739593", Email = "email104@gmail.com", Gabinete = "E104" },
                new Professor { Nome = "Abílio Manuel Pereira da Silva", Contacto = "989647558", Email = "email105@gmail.com", Gabinete = "E105" },
                new Professor { Nome = "Victor Moreno Pérez", Contacto = "968667809", Email = "email106@gmail.com", Gabinete = "E106" },
                new Professor { Nome = "Vitor Hugo Borrata dos Santos", Contacto = "959809001", Email = "email107@gmail.com", Gabinete = "E107" },
                new Professor { Nome = "Vitor Manuel Pinto de Figueiredo", Contacto = "970506834", Email = "email108@gmail.com", Gabinete = "E108" },
                new Professor { Nome = "Zélia Maria da Silva Serrasqueiro Teixeira", Contacto = "910687324", Email = "email109@gmail.com", Gabinete = "E109" },
                new Professor { Nome = "Tiago Jorge Alves Fernandes", Contacto = "920786237", Email = "email110@gmail.com", Gabinete = "E110" },
                new Professor { Nome = "Toufek Metidji", Contacto = "933778242", Email = "email111@gmail.com", Gabinete = "E111" },
                new Professor { Nome = "Susana Maria Palavra Garrido Azevedo", Contacto = "989597527", Email = "email112@gmail.com", Gabinete = "E112" }
            );

            db.SaveChanges();
        }
        private static void PopulateFuncionario(IPGFuncionariosDbContext db) {
            if (db.Funcionario.Any()) {
                return;
            }

            db.Funcionario.AddRange(
                new Funcionario { Nome = "Lina Sousa", Telefone = "234567890", Email = "lina@gmail.com", Genero = "F", Morada = "Rua Xanana Gusmão ", DataNascionento = new DateTime(1973, 07, 03) },
               new Funcionario { Nome = "Lara Lima", Telefone = "912344567", Email = "lima@gmail.com", Genero = "F", Morada = "Rua Páiva", DataNascionento = new DateTime(1970, 07, 03) },
                new Funcionario { Nome = "João Rita", Telefone = "923456211", Email = "joaorita@gmail.com", Genero = "m", Morada = "Rua da Alegria nº2, guarda ", DataNascionento = new DateTime(1972, 07, 03) },


                new Funcionario { Nome = "Lizana Sousa", Telefone = "234567891", Email = "lizana@gmail.com", Genero = "F", Morada = "Rua Xanana Gusmão ", DataNascionento = new DateTime(1972, 07, 03) },
                new Funcionario { Nome = "Laria Lima", Telefone = "912344568", Email = "laria@gmail.com", Genero = "F", Morada = "Rua Páiva", DataNascionento = new DateTime(1972, 07, 04) },
                new Funcionario { Nome = "Jose Rita", Telefone = "923456212", Email = "joserita@gmail.com", Genero = "m", Morada = "Rua da Alegria nº2, guarda ", DataNascionento = new DateTime(1972, 07, 03) },

                new Funcionario { Nome = "Lazaro Sousa", Telefone = "234567892", Email = "lazaro@gmail.com", Genero = "m", Morada = "Rua Xanana Gusmão ", DataNascionento = new DateTime(1998, 07, 03) },
                new Funcionario { Nome = "Felipe Lima", Telefone = "912344569", Email = "felip@gmail.com", Genero = "M", Morada = "Rua Páiva", DataNascionento = new DateTime(1989, 07, 03) },
                new Funcionario { Nome = "Paulo Rita", Telefone = "923456213", Email = "pa@gmail.com", Genero = "m", Morada = "Rua da Alegria nº2, guarda ", DataNascionento = new DateTime(1972, 07, 03) },


                new Funcionario { Nome = "Lina Sousa", Telefone = "234567890", Email = "lina@gmail.com", Genero = "F", Morada = "Rua Xanana Gusmão ", DataNascionento = new DateTime(1979, 07, 03) },
                new Funcionario { Nome = "Lara Lima", Telefone = "912344567", Email = "lima@gmail.com", Genero = "F", Morada = "Rua Páiva", DataNascionento = new DateTime(1956, 07, 03) },
                new Funcionario { Nome = "João Rita", Telefone = "923456211", Email = "joaorita@gmail.com", Genero = "m", Morada = "Rua da Alegria nº2, guarda ", DataNascionento = new DateTime(1998, 07, 03) }
            );

            db.SaveChanges();
        }
        private static void PopulateDepartamento(IPGFuncionariosDbContext db) {
            if (db.Departamento.Any()) {
                return;
            }

            // Dados do departamento
            db.Departamento.AddRange(
                new Departamento { Nome = "Departamento de Engenharia Civil" },
                new Departamento { Nome = "Departamento de Engenharia Informática" },
                new Departamento { Nome = "Departamento de Física", },
                new Departamento { Nome = "Departamento de Engenharia Topográfica" },
                new Departamento { Nome = "Departamento de Energia e Ambiente" },
                new Departamento { Nome = "Departamento de Farmácia" },
                new Departamento { Nome = "Departamento de Hotelaria" },
                new Departamento { Nome = "Departamento de Desporto" },
                new Departamento { Nome = "Departamento de Comunicação Multimédia" }
            );

            db.SaveChanges();
        }
        public static void PopulateFerias(IPGFuncionariosDbContext db){
             if (db.Ferias.Any()) {
                 return;
             }
             db.Ferias.AddRange(
                  new Ferias { TipoFerias = "Ferias de Natal", DataInicio = new DateTime(2019,12 ,18), DataFim = new DateTime(2020,01,03) },
                  new Ferias { TipoFerias="Feria de Carnaval",DataInicio = new DateTime(2020,02,24), DataFim= new DateTime(2020,02,26)},
                 new Ferias { TipoFerias="Feria da Pascoa",DataInicio = new DateTime(2020,03,30), DataFim= new DateTime(2020,04,13)},
                 new Ferias { TipoFerias="Feria do final do Ano Lectivo",DataInicio = new DateTime(2020,06,19), DataFim= new DateTime(2020,09,06)}
                




                 );



         }
         
    }
}