package com.example.bookclub.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.bookclub.models.Book;
import com.example.bookclub.repositories.BookRepo;

@Service
public class BookServ {

	@Autowired
	private BookRepo bookRepo;
	
	
//	======
//	CREATE
//	======
	public Book createOne(Book book) {
		return bookRepo.save(book);
	}
	
//	====
//	READ
//	====
	public List<Book> getAll() {
		return bookRepo.findAll();
	}
	public Book getOne(Long id) {
		return bookRepo.findById(id).orElse(null);
	}
	
//	======
//	UPDATE
//	======
	public Book updateOne(Book book) {
		return bookRepo.save(book);
	}
	
	public Book findBook(Long id) {
    	Optional<Book>optionalBook = bookRepo.findById(id);
    	if(optionalBook.isPresent()) {
    		return optionalBook.get();
    	}else {
    		return null;
    	}
    }
	
//	======
//	DELETE
//	======
	public void deleteOne(Long id) {
		bookRepo.deleteById(id);
	}
}
