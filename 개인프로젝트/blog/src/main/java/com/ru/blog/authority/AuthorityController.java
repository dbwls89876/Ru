package com.ru.blog.authority;


import com.ru.blog.authority.service.UserService;
import com.ru.blog.common.Message;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RequiredArgsConstructor
@RestController
@RequestMapping("/auth")
public class AuthorityController {
    private final UserService userService;

//    @PostMapping
//    public ResponseEntity<Message> login(User user){
//        Message message = new Message();
//
//        return new ResponseEntity<Message>(message, message.getStatus());
//    }
}
