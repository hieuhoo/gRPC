namespace gRPCqlsinhvien.Models.DTO
{
    public class StudentViewDTO
{
        public int Stt { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public String Ngaysinh { get; set; }
        public String Diachi { get; set; }
        public String Classname { get; set; }
        public override string ToString()
        {
            return $"{Stt}-{Name} - {Ngaysinh} -{Diachi} -{Classname}";
        }
    }
}
