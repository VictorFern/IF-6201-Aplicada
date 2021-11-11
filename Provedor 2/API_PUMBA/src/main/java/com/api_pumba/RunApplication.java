package com.api_pumba;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@SpringBootApplication @ComponentScan({"com.api_pumba.controller", "com.api_pumba.repository", "com.api_pumba.service"} )
@EnableJpaRepositories("com.api_pumba.repository")

public class RunApplication {

    public static void main(String[] args) {

        SpringApplication.run(RunApplication.class, args);
    }

    @GetMapping("/greet")
    public String greet(@RequestParam(value = "myName", defaultValue = "World") String name) {
        return String.format("Hello %s!", name);
    }

}
