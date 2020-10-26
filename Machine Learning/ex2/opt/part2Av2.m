function [test,testlabels] = part2Av2(benchmarkdata, featureNo)

feature = extractmyfeatures(getonedigit(1,1,benchmarkdata),featureNo);

noOfFeatures = size(feature,2);
test = zeros(1500, noOfFeatures);

random = randperm(500);
for i = 1:500
    test(i,:) = extractmyfeatures(getonedigit(3, random(:,i), ...
                                                 benchmarkdata),featureNo);
    test(500 + i,:) = extractmyfeatures(getonedigit(6, ...
                               random(:,i), benchmarkdata),featureNo);
    test(1000 + i,:) = extractmyfeatures(getonedigit(8, ...
                               random(:,i), benchmarkdata),featureNo);
end
testlabels = [repmat(3, 500, 1);repmat(6,500,1); ...
              repmat(8,500,1)];
          

