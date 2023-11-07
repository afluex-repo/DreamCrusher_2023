using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DreamCrusher.Models
{
    public class Master : Common
    {
        public string Description { get; set; }
        public string DeletedBy { get; set; }
        public string Pk_ProductServiceID { get; set; }
        public string UploadDate { get; set; }
        public string Image { get; set; }
        public List<Master> lstGallery1 { get; set; }
        public string PK_GalleryID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string IGST { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string BinaryPercent { get; set; }
        public string DirectPercent { get; set; }
        public string ROIPercent { get; set; }
        public List<Master> lstproduct { get; set; }

        public string NewsID { get; set; }
        public string NewsHeading { get; set; }
        public string NewsBody { get; set; }
        public string NewsDate { get; set; }
        public string BV { get; set; }
        public string DirectIncome { get; set; }
        public string SelfDirectIncomeLimit { get; set; }


        public List<Master> lstproductandServices { get; set; }
        public List<Master> lstNews { get; set; }

        public List<Master> lstCourse { get; set; }
        public List<Master> lstCourses { get; set; }
        public string CourseID { get; set; }
        public string FK_CourseID { get; set; }
        public string CourseName { get; set; }
        public string CoursePrice { get; set; }
        public string CourseImage { get; set; }
        public string CourseLink { get; set; }
        public string CourseDate { get; set; }
        public string status { get; set; }

        public string Title { get; set; }



        public string Package { get; set; }
        public string Fk_PackageId { get; set; }
        public DataTable dtTable { get; set; }

        #region ProductMaster

        public DataSet SaveProduct()
        {
            SqlParameter[] para = { new SqlParameter("@ProductName", ProductName),
                                  new SqlParameter("@ProductPrice", ProductPrice),
                                  new SqlParameter("@IGST", IGST),
                                  new SqlParameter("@CGST", CGST),
                                  new SqlParameter("@SGST", SGST),
                                  new SqlParameter("@BinaryPercent", BinaryPercent),
                                  new SqlParameter("@DirectPercent", DirectPercent),
                                  new SqlParameter("@ROIPercent", ROIPercent),
                                  new SqlParameter("@BV",BV),
                                  new SqlParameter("@DirectIncome",DirectIncome),
                                  new SqlParameter("@SelfDirectIncomeLimit",SelfDirectIncomeLimit),
                                  new SqlParameter("@AddedBy", AddedBy)};

            DataSet ds = DBHelper.ExecuteQuery("AddProduct", para);
            return ds;
        }

        public DataSet ProductList()
        {
            SqlParameter[] para = {
                new SqlParameter("@ProductID", ProductID)
                                  };
            DataSet ds = DBHelper.ExecuteQuery("GetProductList", para);
            return ds;
        }

        public DataSet SavingGalleryMaster()
        {
            SqlParameter[] para = { new SqlParameter("@AddedBy", AddedBy),
             new SqlParameter("@Image", Image)
            };
            DataSet ds = DBHelper.ExecuteQuery("GalleryMaster", para);
            return ds;
        }

        public DataSet GetGalleryList()
        {
            SqlParameter[] para = { new SqlParameter("@PK_GalleryID", PK_GalleryID)
            };
            DataSet ds = DBHelper.ExecuteQuery("GetGalleryImages",para);
            return ds;
        }

        public DataSet DeleteProduct()
        {
            SqlParameter[] para = { new SqlParameter("@ProductID", ProductID),
                                  new SqlParameter("@DeletedBy", AddedBy),};

            DataSet ds = DBHelper.ExecuteQuery("DeleteProduct", para);
            return ds;
        }

        public DataSet UpdateProduct()
        {
            SqlParameter[] para = { new SqlParameter("@ProductID", ProductID),
                                  new SqlParameter("@ProductName", ProductName),
                                  new SqlParameter("@ProductPrice", ProductPrice),
                                  new SqlParameter("@IGST", IGST),
                                  new SqlParameter("@CGST", CGST),
                                  new SqlParameter("@SGST", SGST),
                                  new SqlParameter("@BinaryPercent", BinaryPercent),
                                  new SqlParameter("@DirectPercent", DirectPercent),
                                  new SqlParameter("@ROIPercent", ROIPercent),
                                  new SqlParameter("@BV", BV),
                                  new SqlParameter("@DirectIncome",DirectIncome),
                                  new SqlParameter("@SelfDirectIncomeLimit",SelfDirectIncomeLimit),
                                  new SqlParameter("@UpdatedBy", UpdatedBy)};

            DataSet ds = DBHelper.ExecuteQuery("UpdateProduct", para);
            return ds;
        }

        #endregion

        #region NewsMaster

        public DataSet SaveNews()
        {
            SqlParameter[] para = { new SqlParameter("@NewsHeading", NewsHeading),
                                  new SqlParameter("@NewsBody", NewsBody),
                                  new SqlParameter("@AddedBy", AddedBy)};

            DataSet ds = DBHelper.ExecuteQuery("AddNews", para);
            return ds;
        }

        public DataSet NewsList()
        {
            SqlParameter[] para = { new SqlParameter("@NewsID", NewsID) };
            DataSet ds = DBHelper.ExecuteQuery("NewsList", para);
            return ds;
        }

        public DataSet UpdateNews()
        {
            SqlParameter[] para = { new SqlParameter("@NewsID", NewsID),
                                  new SqlParameter("@NewsHeading", NewsHeading),
                                  new SqlParameter("@NewsBody", NewsBody),
                                  new SqlParameter("@UpdatedBy", UpdatedBy) };

            DataSet ds = DBHelper.ExecuteQuery("UpdateNews", para);
            return ds;
        }

        public DataSet DeleteNews()
        {
            SqlParameter[] para = { new SqlParameter("@NewsID", NewsID),
                                  new SqlParameter("@DeletedBy", AddedBy),};

            DataSet ds = DBHelper.ExecuteQuery("DeleteNews", para);
            return ds;
        }

        public DataSet DeleteGalleryImages()
        {
            SqlParameter[] para = { new SqlParameter("@PK_GalleryID", PK_GalleryID),
                                  new SqlParameter("@DeletedBy", AddedBy),};

            DataSet ds = DBHelper.ExecuteQuery("DeleteGallery", para);
            return ds;
        }

        #endregion

        #region CourseMaster

        public DataSet SaveCourse()
        {
            SqlParameter[] para = { new SqlParameter("@CourseName", CourseName),
                                  new SqlParameter("@CourseImage", CourseImage),
                                  new SqlParameter("@CourseLink", CourseLink),
                                  new SqlParameter("@Title", Title),
                                  new SqlParameter("@Description",Description),
                                  new SqlParameter("@AddedBy", AddedBy)};

            DataSet ds = DBHelper.ExecuteQuery("AddCourse", para);
            return ds;
        }

        public DataSet CourseList()
        {
            SqlParameter[] para = {new SqlParameter("@PK_CourseID", CourseID)};
            DataSet ds = DBHelper.ExecuteQuery("GetCourseList", para);
            return ds;
        }

        public DataSet UpdateCourse()
        {
            SqlParameter[] para = {new SqlParameter("@CourseID", CourseID),
                                  new SqlParameter("@CourseName", CourseName),
                                  new SqlParameter("@CourseImage", CourseImage),
                                  new SqlParameter("@CourseLink", CourseLink),
                                  new SqlParameter("@Title", Title),
                                  new SqlParameter("@Description",Description),
                                  new SqlParameter("@UpdatedBy", UpdatedBy)
            };
            DataSet ds = DBHelper.ExecuteQuery("UpdateCourse", para);
            return ds;
        }

        public DataSet DeleteCourse()
        {
            SqlParameter[] para = { new SqlParameter("@CourseID", CourseID),
                                  new SqlParameter("@DeletedBy", AddedBy),
            };
            DataSet ds = DBHelper.ExecuteQuery("DeleteCourse", para);
            return ds;
        }

        #endregion

        public DataSet GetPackageList()
        {
            DataSet ds = DBHelper.ExecuteQuery("GetPackageList");
            return ds;
        }

        public DataSet SaveAllotCoursesOnPackage()
        {
            SqlParameter[] para =
             {
                 new SqlParameter("@Fk_PackageId",Package),
                 new SqlParameter("@dtcoursepackage",dtTable),
                new SqlParameter("@AddedBy",AddedBy)
            };
            DataSet ds = DBHelper.ExecuteQuery("SaveAllotCoursesOnPackage", para);
            return ds;
        }

        public DataSet GetCourseListForAllotCourses()
        {
            SqlParameter[] para = { new SqlParameter("@FK_PackageId", Package)};
            DataSet ds = DBHelper.ExecuteQuery("GetCourseListForAllotCourses", para);
            return ds;
        }


        public DataSet ActiveProduct()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@ProductID", ProductID),
                                      new SqlParameter("@ApprovedBy", AddedBy)
                                     };
            DataSet ds = DBHelper.ExecuteQuery("ActiveProduct", para);
            return ds;
        }

        public DataSet InactiveProduct()
        {
            SqlParameter[] para = {
                                      new SqlParameter("@ProductID", ProductID),
                                      new SqlParameter("@RejectedBy", AddedBy)
                                     };
            DataSet ds = DBHelper.ExecuteQuery("InactiveProduct", para);
            return ds;
        }

        public DataSet SaveProductandServices()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@ProductName", ProductName),
                                    new SqlParameter("@Amount", ProductPrice),
                                    new SqlParameter("@Image", Image),
                                    new SqlParameter("@AddedBy", AddedBy)
                                  };

            DataSet ds = DBHelper.ExecuteQuery("InsertProductandServices", para);
            return ds;
        }

        public DataSet ProductandServicesList()
        {
            SqlParameter[] para =
            {
                new SqlParameter("@Pk_ProductServiceID",Pk_ProductServiceID)
            };
            DataSet ds = DBHelper.ExecuteQuery("GetProductandServicesList",para);
            return ds;
        }

        public DataSet DeleteProductandServices()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Pk_ProductServiceID",Pk_ProductServiceID),
                                    new SqlParameter("@DeletedBy",DeletedBy)
                                  };

            DataSet ds = DBHelper.ExecuteQuery("DeleteProductandServices", para);
            return ds;
        }

        public DataSet UpdateProductandServices()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Pk_ProductServiceID",Pk_ProductServiceID),
                                    new SqlParameter("@ProductName", ProductName),
                                    new SqlParameter("@Amount", ProductPrice),
                                    new SqlParameter("@Image", Image),
                                    new SqlParameter("@UpdatedBy", UpdatedBy)
                                  };

            DataSet ds = DBHelper.ExecuteQuery("UpdateProductandServices", para);
            return ds;
        }
    }
}