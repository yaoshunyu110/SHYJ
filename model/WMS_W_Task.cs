using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZJSoft.DbHelper.DataAccess;


namespace ZJ_ECS_JLX_COS.Model
{
      [DbTab("WMS_W_Task","ID")]
      public class WMS_W_Task
      {
            /// <summary>
            /// 自增编号
            /// </summary>
            [DbBind("ID")]
            public string ID { set; get; }
            /// <summary>
            /// 入库条码/出库条码
            /// </summary>
            [DbBind("Barcode")]
            public string Barcode { set; get; }
            /// <summary>
            /// 导入时间
            /// </summary>
            [DbBind("ImportTime")]
            public string ImportTime { set; get; }
            /// <summary>
            /// 操作人
            /// </summary>
            [DbBind("ImportUserId")]
            public string ImportUserId { set; get; }
            /// <summary>
            /// --Status WMS_W_Ttask 任务表状态 
     /// </summary>
            [DbBind("Status")]
            public string Status { set; get; }
            /// <summary>
            /// 上传Erp 标识  默认0或null,1-本地已更新待上传,2-上传Erp完成
            /// </summary>
            [DbBind("UpdateFlag")]
            public string UpdateFlag { set; get; }
            /// <summary>
            /// 数据来源 0-ERP导入,1-本地创建
            /// </summary>
            [DbBind("DataSources")]
            public string DataSources { set; get; }
            /// <summary>
            /// 任务请求ID
            /// </summary>
            [DbBind("TaskId")]
            public string TaskId { set; get; }
            /// <summary>
            /// 供应商交货单号
            /// </summary>
            [DbBind("EIRNumber")]
            public string EIRNumber { set; get; }
            /// <summary>
            /// 物料编码
            /// </summary>
            [DbBind("MaterialId")]
            public string MaterialId { set; get; }
            /// <summary>
            /// 物料名称
            /// </summary>
            [DbBind("MaterialName")]
            public string MaterialName { set; get; }
            /// <summary>
            /// 请求数量
            /// </summary>
            [DbBind("RequestQuantity")]
            public string RequestQuantity { set; get; }
            /// <summary>
            /// 完成数量（验收数量）
            /// </summary>
            [DbBind("CompledQuantity")]
            public string CompledQuantity { set; get; }
            /// <summary>
            /// 库存数量
   
            /// </summary>
            [DbBind("InvQuantity")]
            public string InvQuantity { set; get; }
            /// <summary>
            /// 入/出库标识
  
            /// </summary>
            [DbBind("InOutFlag")]
            public string InOutFlag { set; get; }
            /// <summary>
            /// 立体库标识
            /// </summary>
            [DbBind("StoreTypeFlag")]
            public string StoreTypeFlag { set; get; }
            /// <summary>
            /// 免检/送检

            /// </summary>
            [DbBind("ExamineFlag")]
            public string ExamineFlag { set; get; }
            /// <summary>
            /// 批次
            /// </summary>
            [DbBind("BatchNo")]
            public string BatchNo { set; get; }
            /// <summary>
            /// 寄售/非寄售
            /// </summary>
            [DbBind("ConsignmentFlag")]
            public string ConsignmentFlag { set; get; }
            /// <summary>
            /// 进口/非进口
            /// </summary>
            [DbBind("ImportFlag")]
            public string ImportFlag { set; get; }
            /// <summary>
            /// 单据
            /// </summary>
            [DbBind("BillNo")]
            public string BillNo { set; get; }
            /// <summary>
            /// 工位
            /// </summary>
            [DbBind("Position")]
            public string Position { set; get; }
            /// <summary>
            /// 部件编码
            /// </summary>
            [DbBind("ComponentCode")]
            public string ComponentCode { set; get; }
            /// <summary>
            /// 补缺数量:入库单据时由SAP填写需要补缺数量；出库单据时由WMS填写已经处理的补缺数量。
            /// </summary>
            [DbBind("VacancyQuantity")]
            public string VacancyQuantity { set; get; }
            /// <summary>
            /// 部门编码
            /// </summary>
            [DbBind("DepartmentCode")]
            public string DepartmentCode { set; get; }
            /// <summary>
            /// 经手人
            /// </summary>
            [DbBind("Operator")]
            public string Operator { set; get; }
            /// <summary>
            /// 工作令
            /// </summary>
            [DbBind("WorkOrder")]
            public string WorkOrder { set; get; }
            /// <summary>
            /// 创建时间
            /// </summary>
            [DbBind("CreatedTime")]
            public string CreatedTime { set; get; }
            /// <summary>
            /// 加急
  
            /// </summary>
            [DbBind("UrgentFlag")]
            public string UrgentFlag { set; get; }
            /// <summary>
            /// 订单号
            /// </summary>
            [DbBind("OrderNo")]
            public string OrderNo { set; get; }
            /// <summary>
            /// 行号
            /// </summary>
            [DbBind("ItemNo")]
            public string ItemNo { set; get; }
            /// <summary>
            /// ABC标识
            /// </summary>
            [DbBind("ABCFlag")]
            public string ABCFlag { set; get; }
            /// <summary>
            /// 油漆色
            /// </summary>
            [DbBind("PaintColor")]
            public string PaintColor { set; get; }
            /// <summary>
            /// 特殊防护
            /// </summary>
            [DbBind("SpecialProtection")]
            public string SpecialProtection { set; get; }
            /// <summary>
            /// 机型
            /// </summary>
            [DbBind("EquipmentModel")]
            public string EquipmentModel { set; get; }
            /// <summary>
            /// 体积
            /// </summary>
            [DbBind("Volume")]
            public string Volume { set; get; }
            /// <summary>
            /// 第一次验收结果
            /// </summary>
            [DbBind("FirstAcceptanceQuantity")]
            public string FirstAcceptanceQuantity { set; get; }
            /// <summary>
            /// 合格数
            /// </summary>
            [DbBind("QualifiedQuantity")]
            public string QualifiedQuantity { set; get; }
            /// <summary>
            /// 第二次验收结果
            /// </summary>
            [DbBind("SecondAcceptanceQuantity")]
            public string SecondAcceptanceQuantity { set; get; }
            /// <summary>
            /// 入库单号
            /// </summary>
            [DbBind("DocumentNO")]
            public string DocumentNO { set; get; }
            /// <summary>
            /// 验收货人
            /// </summary>
            [DbBind("CheckNumUserId")]
            public string CheckNumUserId { set; get; }
            /// <summary>
            /// 验收日期
            /// </summary>
            [DbBind("CheckNumDate")]
            public string CheckNumDate { set; get; }
            /// <summary>
            /// 
            /// </summary>
            [DbBind("CheckNumUserId_1")]
            public string CheckNumUserId_1 { set; get; }
            /// <summary>
            /// 并单任务号，当ERP出库任务导入本地任务表，人员需要并单处理时，可以通过并单操作生产新的出库任务（WMS_W_Task），同时在被并单任务的此字段写入并单后的新任务号，未做并单处理的此字段为空。

            /// </summary>
            [DbBind("CombinedTask")]
            public string CombinedTask { set; get; }
            /// <summary>
            /// 是否为并单 1-是 0否
            /// </summary>
            [DbBind("IsMerge")]
            public string IsMerge { set; get; }
            /// <summary>
            /// 扩展属性1  ：出库任务人工增加的备注
            /// </summary>
            [DbBind("ExtAttr1")]
            public string ExtAttr1 { set; get; }
            /// <summary>
            /// 扩展属性2：出库任务分解完成，填入已分解的数量，如果库存不足记录实际分解的数量，没库存，此字段不更新
            /// </summary>
            [DbBind("ExtAttr2")]
            public string ExtAttr2 { set; get; }
            /// <summary>
            /// 优先颜色：当出库时 ，根据此颜色进行查询计算，默认色'00'
            /// </summary>
            [DbBind("Color_F")]
            public string Color_F { set; get; }
            /// <summary>
            /// 备注说明
            /// </summary>
            [DbBind("Remark")]
            public string Remark { set; get; }
            /// <summary>
            /// 图号
            /// </summary>
            [DbBind("PartDwg_No")]
            public string PartDwg_No { set; get; }
            /// <summary>
            /// 提交批次，出库分解任务时根据该字段查询本次提交的任务
            /// </summary>
            [DbBind("TaskFlag")]
            public string TaskFlag { set; get; }
            /// <summary>
            /// 
            /// </summary>
            [DbBind("Required_Date")]
            public string Required_Date { set; get; }
            /// <summary>
            /// 分解说明
            /// </summary>
            [DbBind("ResolveRemark")]
            public string ResolveRemark { set; get; }
            /// <summary>
            /// SAP处理标识，入库： 

            /// </summary>
            [DbBind("CheckFlag")]
            public string CheckFlag { set; get; }
            /// <summary>
            /// 出库口分类（出库合并时人工选择，未分解前可调整）
            /// </summary>
            [DbBind("OutLocType")]
            public string OutLocType { set; get; }
            /// <summary>
            /// 排序序号（出库合并单据时人工填写，后续可调整）
            /// </summary>
            [DbBind("Seq")]
            public string Seq { set; get; }
            /// <summary>
            /// 完成时间
            /// </summary>
            [DbBind("CompletedTime")]
            public string CompletedTime { set; get; }
      }
}
