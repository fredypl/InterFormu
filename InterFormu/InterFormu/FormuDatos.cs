using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace InterFormu
{
    [Table("Datos")]
    public class FormuDatos
    {
        int id;
        string dato1;
        string dato2;
        string dato3;
        string dato4;
        Int64 dato5;
        string dato6;
        string dato7;
        Int32 dato8;
        string dato9;
        string dato10;

        [PrimaryKey, Unique, MaxLength(10)]
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        [Column("Nombre"), MaxLength(20)]
        public string Dato1
        {
            get { return dato1; }
            set { dato1 = value; }

        }
        [Column("Apellido Paterno"), MaxLength(20)]
        public string Dato2
        {
            get { return dato2; }
            set { dato2 = value; }
        }
        [Column("Apellido Materno"), MaxLength(20)]
        public string Dato3
        {
            get { return dato3; }
            set { dato3 = value; }
        }
        [Column("Direccion"), MaxLength(80)]
        public string Dato4
        {
            get { return dato4; }
            set { dato4 = value; }
        }
        [Column("Telefono"), MaxLength(10)]
        public Int64 Dato5
        {
            get { return dato5; }
            set { dato5 = value; }
        }
        [Column("Carrera"), MaxLength(38)]
        public string Dato6
        {
            get { return dato6; }
            set { dato6 = value; }
        }
        [Column("Semestre"), MaxLength(7)]
        public string Dato7
        {
            get { return dato7; }
            set { dato7 = value; }
        }
        [Column("Matricula"), MaxLength(8)]
        public Int32 Dato8
        {
            get { return dato8; }
            set { dato8 = value; }
        }
        [Column("Correo"), MaxLength(30)]

        public string Dato9
        {
            get { return dato9; }
            set { dato9 = value; }
        }
        [Column("Github"), MaxLength(15)]
        public string Dato10
        {
            get { return dato10; }
            set { dato10 = value; }
        }
    }
}
