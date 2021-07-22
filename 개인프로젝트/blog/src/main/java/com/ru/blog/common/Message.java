package com.ru.blog.common;

import lombok.Getter;
import lombok.Setter;
import org.springframework.http.HttpStatus;

@Getter
@Setter
public class Message {
    String message;
    HttpStatus status;
    Object data;

    public Message(){
        message = "success";
        status = HttpStatus.OK;
        data = null;
    }
}
