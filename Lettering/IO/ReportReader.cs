﻿using System;
using System.Data;
using System.Collections.Generic;
using Lettering.IO;
using Lettering.Errors;

namespace Lettering {
    internal class ReportReader {
        internal static DataTable RunReport(DateTime? startDate, DateTime? endDate, LetteringType reportType) {
            string dateClause;
            if(startDate.HasValue && endDate.HasValue) {
                //NOTE(adam): start and end could be reversed or same
                DateTime start;
                DateTime end;
                if(startDate.Value <= endDate.Value) {
                    start = startDate.Value;
                    end = endDate.Value;
                } else {
                    start = endDate.Value;
                    end = startDate.Value;
                }

                dateClause = string.Format("((d.dorcy = {0}) AND (d.doryr = {1}) AND (d.dormo = {2}) AND (d.dorda = {3}))",
                                           start.Year / 100, start.Year % 100, start.Month, start.Day);
                start = start.AddDays(1);
                while(start <= end) {
                    dateClause += string.Format(" OR ((d.dorcy = {0}) AND (d.doryr = {1}) AND (d.dormo = {2}) AND (d.dorda = {3}))",
                                               start.Year / 100, start.Year % 100, start.Month, start.Day);
                    start = start.AddDays(1);
                }
            } else if(startDate.HasValue || endDate.HasValue) {
                DateTime date = (startDate.HasValue ? startDate.Value : endDate.Value);
                dateClause = string.Format("((d.dorcy = {0}) AND (d.doryr = {1}) AND (d.dormo = {2}) AND (d.dorda = {3}))",
                                           date.Year / 100, date.Year % 100, date.Month, date.Day);
            } else { 
                //NOTE(adam): default is yesterday
                List<DateTime> holidays = ConfigReader.ReadHolidays();
                DateTime date = DateTime.Today.AddDays(-1);

                dateClause = string.Format("((d.dorcy = {0}) AND (d.doryr = {1}) AND (d.dormo = {2}) AND (d.dorda = {3}))",
                                           date.Year / 100, date.Year % 100, date.Month, date.Day);

                //NOTE(adam): adding days to search for to cover non work days (weekends, holidays, etc)
                while(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || holidays.Contains(date)) {
                    date = date.AddDays(-1);
                    dateClause += string.Format(" OR ((d.dorcy = {0}) AND (d.doryr = {1}) AND (d.dormo = {2}) AND (d.dorda = {3}))",
                                           date.Year / 100, date.Year % 100, date.Month, date.Day);
                }
            }

            string styleClause = "";
            switch(reportType) {
                case LetteringType.Cut:
                    styleClause = @"
                        (d.dclas IN ('041', '049', '04C', '04D', '04Y', 'F09', 'JVT', 'L02', 'L05', 'L10', 'PS3', 'S03', 'SKL', 'VTT', '04G', 'BHT')) AND 
                        (d.ditem NOT LIKE 'OZ%') AND (d.ditem NOT LIKE 'CF1857%') AND (d.ditem NOT LIKE 'COZ%') AND (d.ditem NOT LIKE 'HTC1%') AND (d.ditem NOT LIKE 'HTC0%') AND (d.ditem NOT LIKE 'HTC2%') AND
                        (d.ditem NOT LIKE 'SP%') AND  (d.ditem NOT LIKE 'HTC3%') AND (d.ditem NOT LIKE 'HTC4%') AND (d.ditem NOT LIKE 'HTC5%') AND (d.ditem NOT LIKE 'HTC6%') AND 
                        (d.ditem NOT LIKE 'HTC7%') AND (d.ditem NOT LIKE 'HTC8%') AND  (d.ditem NOT LIKE 'HTC9%') AND  (d.ditem NOT LIKE 'ICFC%') AND  (d.ditem NOT LIKE 'SDC%') AND
                        (d.ditem NOT LIKE 'IDC%') AND (d.ditem NOT LIKE 'TTC0%') AND (d.ditem NOT LIKE 'TTC1%') AND (d.ditem NOT LIKE 'TTC2%') AND (d.ditem NOT LIKE 'TTC3%') AND 
                        (d.ditem NOT LIKE 'TTC4%') AND (d.ditem NOT LIKE 'TTC5%') AND (d.ditem NOT LIKE 'TTC6%') AND (d.ditem NOT LIKE 'TTC7%') AND (d.ditem NOT LIKE 'TTC8%') AND (d.ditem NOT LIKE 'TTC9%') AND (d.ditem NOT LIKE 'MN%') ";
                    break;
                case LetteringType.Sew:
                    styleClause += @"
                        ((d.ditem LIKE '%MN%') OR (d.ditem LIKE 'PF%') OR (d.ditem LIKE 'FEL%') OR (d.ditem LIKE 'TTP%') OR (d.ditem LIKE 'SP%') OR (d.dlrea LIKE 'ASW')OR (d.ditem LIKE 'PK%')) AND 
                        ((d.ditem NOT LIKE '%CBSLIMN%') AND (d.ditem NOT LIKE '%SLIMN%') AND (d.ditem NOT LIKE '%PKEY%')) AND 
                        (d.dclas NOT IN ('010', '045', '04A', '04B', '04M', '04O', '063', '065', '075', '083', '086', '087', '089', 
                                         '0DB', '0P1', '0P2', '0P6', '112', '123', 'CS2', 'P02', 'P06', 'S01', 'S02', 'SBP', 'SPT', 'SSO', 'STL')) AND 
                        ((d.ditem NOT LIKE 'MN2001%') AND (d.ditem NOT LIKE 'MN2002%') AND (d.ditem NOT LIKE 'MNB1%') AND (d.ditem NOT LIKE 'MNB2%') AND 
                         (d.ditem NOT LIKE 'MNB2N%') AND (d.ditem NOT LIKE 'MNBLN%') AND (d.ditem NOT LIKE 'MNBLNM%') AND (d.ditem NOT LIKE 'MNBL2N%') AND 
                         (d.ditem NOT LIKE 'MNBN1%') AND (d.ditem NOT LIKE 'MNBN2%') AND (d.ditem NOT LIKE 'MNBNCW%') AND (d.ditem NOT LIKE 'MNBNI%') AND 
                         (d.ditem NOT LIKE 'MNBNIM%') AND (d.ditem NOT LIKE 'MNBNM%') AND (d.ditem NOT LIKE 'MNBSFN%') AND (d.ditem NOT LIKE 'MNBSFNM%') AND 
                         (d.ditem NOT LIKE 'MNBSF2N%') AND (d.ditem NOT LIKE 'MNBW1%') AND (d.ditem NOT LIKE 'MNBW2%') AND (d.ditem NOT LIKE 'MNS1%') AND 
                         (d.ditem NOT LIKE 'MNS2%') AND (d.ditem NOT LIKE 'MNS2N%') AND (d.ditem NOT LIKE 'MNS2NNW%') AND (d.ditem NOT LIKE 'MNS3N%') AND 
                         (d.ditem NOT LIKE 'MNSN%') AND (d.ditem NOT LIKE 'MNSNBR%') AND (d.ditem NOT LIKE 'MNSNBRM%') AND (d.ditem NOT LIKE 'MNSNCW%') AND 
                         (d.ditem NOT LIKE 'MNSNM%') AND (d.ditem NOT LIKE 'MNSNNW%') AND (d.ditem NOT LIKE 'MNSNNWCW%') AND (d.ditem NOT LIKE 'MNSNNWM%') AND 
                         (d.ditem NOT LIKE 'MNSW1%') AND (d.ditem NOT LIKE 'MNSW2%') AND (d.ditem NOT LIKE 'MNBRUSH1%') AND (d.ditem NOT LIKE 'MNBRUSH2%') AND 
                         (d.ditem NOT LIKE 'MNNL1%') AND (d.ditem NOT LIKE 'MNNL2%') AND (d.ditem NOT LIKE 'MNNW1%') AND (d.ditem NOT LIKE 'MNNW2%') AND 
                         (d.ditem NOT LIKE 'MNBO1%') AND (d.ditem NOT LIKE 'MNBO2%') AND (d.ditem NOT LIKE 'MNBLC1%') AND (d.ditem NOT LIKE 'MNBLC2%') AND 
                         (d.ditem NOT LIKE 'MNBSF%') AND (d.ditem NOT LIKE 'MNBWI%') AND (d.ditem NOT LIKE 'MNHB1%') AND (d.ditem NOT LIKE 'MNHB2%') AND 
                         (d.ditem NOT LIKE 'MNHBW%') AND (d.ditem NOT LIKE 'MNBP%') AND (d.ditem NOT LIKE 'MNSP1%') AND (d.ditem NOT LIKE 'MNSP2%') AND 
                         (d.ditem NOT LIKE 'MNBWP%') AND (d.ditem NOT LIKE 'MNSWP%') AND (d.ditem NOT LIKE 'MNBRWP%') AND (d.ditem NOT LIKE 'MNNWP%')) ";
                    break;
                case LetteringType.Stone:
                    styleClause += @"
                        (d.dclas IN ('04U', '04V', '04W', 'L01', 'L03', 'L04', 'L09', 'F09', 'PS3', 'RSC', 'RSO', 'TSO')) AND 
                        ((d.ditem LIKE 'RH%') OR (d.ditem LIKE 'TS%') OR (d.ditem LIKE 'TSB%') OR (d.ditem LIKE 'RHB%') OR (d.ditem LIKE 'RST%') OR (d.ditem Like 'RVOMMPT%'))";
                    break;
                case LetteringType.ASFStone:
                    styleClause += @"
                        (d.dclas IN ('L09' , 'L08')) AND 
                        ((d.ditem LIKE 'RSASF%') OR (d.ditem LIKE 'TSASF%') OR (d.ditem LIKE 'RUASF%') OR (d.ditem LIKE 'RMASF%'))";
                    break;
                case LetteringType.PHT:
                    styleClause += @"
                        (d.dclas IN ('L16')) AND 
                        ((d.ditem LIKE 'PHT%'))";
                    break;
                default:
                    ErrorHandler.HandleError(ErrorType.Critical, "Invalid report type in RunReport.");
                    break;
            }

            DataTable reportTable = SqlConnector.RunQuery(dateClause, styleClause);

            return reportTable;
        }
    }
}
