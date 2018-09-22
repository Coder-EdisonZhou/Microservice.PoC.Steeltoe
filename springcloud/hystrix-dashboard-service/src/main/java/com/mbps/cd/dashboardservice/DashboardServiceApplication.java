package com.mbps.cd.dashboardservice;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.netflix.hystrix.dashboard.EnableHystrixDashboard;

@SpringBootApplication
@EnableHystrixDashboard
public class DashboardServiceApplication {
	public static void main(String[] args) {
		SpringApplication.run(DashboardServiceApplication.class, args);
	}
}
