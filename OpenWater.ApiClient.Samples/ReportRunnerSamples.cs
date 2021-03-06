﻿using System;
using System.Threading;
using System.Threading.Tasks;
using OpenWater.ApiClient.BackgroundJob;
using OpenWater.ApiClient.Definitions;
using OpenWater.ApiClient.ReportRunner;

namespace OpenWater.ApiClient.Samples
{
    public static class ReportRunnerSamples
    {
        private static readonly OpenWaterApiClient ApiClient = Program.ApiClient;

        /// <summary>
        /// Run report background job by id 83001 and wait until job finished as succeed or failed and get result async
        /// </summary>
        public static async Task<DetailsResponse> RunReportBackgroundJobAsync()
        {
            const int reportId = 83001;
            var reportExportFormat = new RunRequest("xlsx");

            var jobId = (await ApiClient.RunReportAsync(reportId, reportExportFormat)).JobId;

            while (true)
            {
                var jobState = (await ApiClient.GetJobByIdAsync(jobId)).JobState;

                if (jobState == StateType.Succeeded || jobState == StateType.Failed)
                    return await ApiClient.GetJobByIdAsync(jobId);

                Thread.Sleep(millisecondsTimeout: 1000);
            }
        }

        /// <summary>
        /// Run report background job by id 83001 and wait until job finished as succeed or failed and get result
        /// </summary>
        public static DetailsResponse RunReportBackgroundJob()
        {
            const int reportId = 83001;
            var reportExportFormat = new RunRequest("xlsx");

            var jobId = ApiClient.RunReport(reportId, reportExportFormat).JobId;

            while (true)
            {
                var jobState = ApiClient.GetJobById(jobId).JobState;

                if (jobState == StateType.Succeeded || jobState == StateType.Failed)
                    return ApiClient.GetJobById(jobId);

                Thread.Sleep(millisecondsTimeout: 1000);
            }
        }
    }
}