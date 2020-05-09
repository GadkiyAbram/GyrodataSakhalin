using Dapper;
using InventoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace InventoryLibrary
{
    public class SqlConnector : IDataConnection
    {
        public ItemModel CreateItem(ItemModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@Item", model.Item);
                p.Add("@Asset", model.Asset);
                p.Add("@Arrived", model.Arrived);
                p.Add("@Invoice", model.Invoice);
                p.Add("@CCD", model.CCD);
                p.Add("@NameRus", model.NameRus);
                p.Add("@PositionCCD", model.PositionCCD);
                p.Add("@ItemStatus", model.ItemStatus);
                p.Add("@Box", model.Box);
                p.Add("@Container", model.Container);
                p.Add("@Comment", model.Comment);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spItems_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }

        public BatteryModel CreateBattery(BatteryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@BoxNumber", model.BoxNumber);
                p.Add("@BatteryCondition", model.BatteryCondition);
                p.Add("@SerialOne", model.SerialOne);
                p.Add("@SerialTwo", model.SerialTwo);
                p.Add("@SerialThr", model.SerialThr);
                p.Add("@CCD", model.CCD);
                p.Add("@Invoice", model.Invoice);
                p.Add("@BatteryStatus", model.BatteryStatus);
                p.Add("@Arrived", model.Arrived);
                p.Add("@Container", model.Container);
                p.Add("@Comment", model.Comment);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBatteries_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }

        public static List<ItemModel> GetEquipmentData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                
                return connection.Query<ItemModel>("spGetAllGwdGyroItems", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Custom Items Records from DB
        public static List<ItemModel> GetCustomEquipmentData(string what, string where)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                var p = new DynamicParameters();

                p.Add("@SearchWhat", what);
                p.Add("@SearchWhere", where);

                return connection.Query<ItemModel>("spGetCustomEquipmentData", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Custom Jobs Records from DB
        public static List<JobModel> GetCustomJobData(string what, string where)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                var p = new DynamicParameters();

                p.Add("@SearchWhat", what);
                p.Add("@SearchWhere", where);

                return connection.Query<JobModel>("spGetCustomJobData", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Batteries Records from DB
        public static List<BatteryModel> GetBatteriesData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                return connection.Query<BatteryModel>("spGetAllBatteriesNew", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<BatteryModel> GetCustomBatteryData(string what, string where)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                var p = new DynamicParameters();

                p.Add("@SearchWhat", what);
                p.Add("@SearchWhere", where);

                return connection.Query<BatteryModel>("spGetCustomBatteryData", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Clients from DB
        public static List<ClientModel> GetClientsData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                return connection.Query<ClientModel>("spGetClientsData", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading GDP from DB
        public static List<ItemModel> GetGdpData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                return connection.Query<ItemModel>("spGetAllGdpData", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Modem from DB
        public static List<ItemModel> GetModemData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                return connection.Query<ItemModel>("spGetAllModemData", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Bbp from DB
        public static List<ItemModel> GetBbpData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                return connection.Query<ItemModel>("spGetAllBbpData", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Engineers from DB
        public static List<EngineerModel> GetEngineerData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                return connection.Query<EngineerModel>("spGetEngineerData", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Creating Job record in DB
        public JobModel CreateJob(JobModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@JobNumber", model.JobNumber);
                p.Add("@Client", model.ClientName);
                p.Add("@GDPAsset", model.GDP);
                p.Add("@ModemAsset", model.Modem);
                p.Add("@ModemVersion", model.ModemVersion);
                p.Add("@BullplugAsset", model.Bullplug);
                p.Add("@CirculationHours", model.CirculationHours);
                p.Add("@Battery", model.Battery);
                p.Add("@MaxTemp", model.MaxTemp);
                p.Add("@EngineerOne", model.EngineerOne);
                p.Add("@EngineerTwo", model.EngineerTwo);
                p.Add("@EngineerOneArrived", model.eng_one_arrived);
                p.Add("@EngineerTwoArrived", model.eng_two_arrived);
                p.Add("@EngineerOneLeft", model.eng_two_arrived);
                p.Add("@EngineerTwoLeft", model.eng_two_left);
                p.Add("@Container", model.Container);
                p.Add("@ContainerArrived", model.ContainerArrived);
                p.Add("@ContainerLeft", model.ContainerLeft);
                p.Add("@Rig", model.Rig);
                p.Add("@Issues", model.Issues);
                p.Add("@Comment", model.Comment);

                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spJob_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }

        // Loading selected Item from DB
        public static List<ItemModel> GetSelectedItem(string selectedItem, string selectedAsset)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                //if (connection.State == ConnectionState.Closed) connection.Open();
                var p = new DynamicParameters();

                p.Add("@SelectedItem", selectedItem);
                p.Add("@SelectedAsset", selectedAsset);

                return connection.Query<ItemModel>("spGetSelectedItemData", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading Jobs from DB
        public static List<JobModel> GetAllJobsData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                //if (connection.State == ConnectionState.Closed) connection.Open();

                return connection.Query<JobModel>("spGetAllJobsData", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Loading selected Job from DB
        public static List<JobModel> GetSelectedJob(string selectedJob)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                //if (connection.State == ConnectionState.Closed) connection.Open();
                var p = new DynamicParameters();

                p.Add("@SelectedJob", selectedJob);

                return connection.Query<JobModel>("spGetSelectedJobData", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void UpdateJob(int id, JobModel model, float circul)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                var p = new DynamicParameters();
                p.Add("@oldJobCirculation", circul);

                p.Add("@Id", id);
                p.Add("@JobNumber", model.JobNumber);
                p.Add("@Client", model.ClientName);
                p.Add("@gdp", model.GDP);
                p.Add("@modem", model.Modem);
                p.Add("@ModemVersion", model.ModemVersion);
                p.Add("@bbp", model.Bullplug);
                p.Add("@newJobCirculation", model.CirculationHours);
                p.Add("@Battery", model.Battery);
                p.Add("@MaxTemp", model.MaxTemp);
                p.Add("@EngineerOne", model.EngineerOne);
                p.Add("@EngineerTwo", model.EngineerTwo);
                p.Add("@EngineerOneArrived", model.eng_one_arrived);
                p.Add("@EngineerTwoArrived", model.eng_two_arrived);
                p.Add("@EngineerOneLeft", model.eng_one_left);
                p.Add("@EngineerTwoLeft", model.eng_two_left);
                p.Add("@Container", model.Container);
                p.Add("@ContainerArrived", model.ContainerArrived);
                p.Add("@ContainerLeft", model.ContainerLeft);
                p.Add("@Rig", model.Rig);
                p.Add("@Issues", model.Issues);
                p.Add("@Comment", model.Comment);

                //p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUpdate_Job", p, commandType: CommandType.StoredProcedure);

                //model.Id = p.Get<int>("@Id");

                //return model;
            }
        }

        public void UpdateItem(int id, ItemModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                var p = new DynamicParameters();

                p.Add("@Id", id);
                p.Add("@ItemItem", model.Item);
                p.Add("@ItemAsset", model.Asset);
                p.Add("@ItemArrived", model.Arrived);
                p.Add("@ItemInvoice", model.Invoice);
                p.Add("@ItemCCD", model.CCD);
                p.Add("@ItemNameRus", model.NameRus);
                p.Add("@PositionCCD", model.PositionCCD);
                p.Add("@ItemStatus", model.ItemStatus);
                p.Add("@ItemBox", model.Box);
                p.Add("@Container", model.Container);
                p.Add("@Comment", model.Comment);

                connection.Execute("dbo.spUpdate_Item", p, commandType: CommandType.StoredProcedure);

            }
        }

        // Check if inserting Item alredy exists in DB
        public static List<ItemModel> CheckIfItemExists(string item, string asset)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                var p = new DynamicParameters();

                p.Add("@ItemItem", item);
                p.Add("@ItemAsset", asset);

                return connection.Query<ItemModel>("spCheckIfItemExitst", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        // Check if Job alredy exists in DB
        public static List<JobModel> CheckIfJobExists(string jobNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("GyrodataTracker")))
            {
                var p = new DynamicParameters();

                p.Add("@JobNumber", jobNumber);

                return connection.Query<JobModel>("spCheckIfJobExists", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
