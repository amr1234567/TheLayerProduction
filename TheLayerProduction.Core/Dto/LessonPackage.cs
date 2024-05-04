namespace TheLayerProduction.Core.Dto
{
    public class LessonPackage
    {
        public string TeacherName { get; set; }

        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public double PackagePrice { get; set; }

        public int LessonId { get; set; }
        public string LessonName { get; set; }

        public string PdfUrl { get; set; }
        public string VideoUrl { get; set; }
    }
}